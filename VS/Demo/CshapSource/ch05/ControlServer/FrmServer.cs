using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;//以下是新添加的名称空间
using System.Net;
using System.Runtime.InteropServices;//这个名称空间提供了一系列的类来对COM对象进行操作
using System.Management;//操作远程和本地计算机上的服务

namespace ControlServer
{
    public partial class FrmServer : Form
    {
        private const int UdpPort = 8002;
        private const int TcpPort = 8004;
        private const string fgf = "|";
        private UdpClient listener = new UdpClient(UdpPort);
        private bool isClose = false;
        private TcpClient tcpClient;
        private TcpListener tcpListener;
        private string macAddress;
        private string ipAddress;

        public FrmServer()
        {
            InitializeComponent();
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Text = this.Text;

            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc2 = mc.GetInstances();
            foreach (ManagementObject mo in moc2)
            {
                if ((bool)mo["IPEnabled"] == true)
                    macAddress = mo["MacAddress"].ToString();
                mo.Dispose();
            }

            foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ip.ToString().Length > 7)
                {
                    ipAddress = ip.ToString();
                }
            }

            //启动Tcp监听开始侦听指定端口
            tcpListener = new TcpListener(Dns.GetHostAddresses(Dns.GetHostName())[0], TcpPort);
            tcpListener.Start();
            backgroundWorkerTcp.RunWorkerAsync();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref   IntPtr phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name, ref   long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
        ref   TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int DoFlag, int rea);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        private static void DoExitWin(int DoFlag)
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref   htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref   tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref   tp, 0, IntPtr.Zero, IntPtr.Zero);
            ok = ExitWindowsEx(DoFlag, 0);
        }

        public static void Reboot()
        {
            DoExitWin(EWX_FORCE | EWX_REBOOT);
        }

        public static void PowerOff()
        {
            DoExitWin(EWX_FORCE | EWX_POWEROFF);
        }

        public static void LogoOff()
        {
            DoExitWin(EWX_FORCE | EWX_LOGOFF);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void StartListener()
        {
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, 0);

            try
            {
                while (true)
                {
                    //接收服务器UDP广播包
                    byte[] bytes = listener.Receive(ref groupEP);
                    string message = Encoding.Unicode.GetString(bytes, 0, bytes.Length);
                    backgroundWorker.ReportProgress(bytes.Length, message);

                    try
                    {
                        //请求服务器连接
                        string serverIp = message.Substring(0, message.IndexOf(fgf));
                        int tcpPort = Convert.ToInt32(message.Substring(message.IndexOf(fgf) + 1, message.Length - message.IndexOf(fgf) - 1));
                        tcpClient = new TcpClient(serverIp, tcpPort);

                        NetworkStream ns = tcpClient.GetStream();
                        byte[] data = Encoding.Unicode.GetBytes(Dns.GetHostName() + fgf + ipAddress + fgf + macAddress);
                        ns.Write(data, 0, data.Length);
                        ns.Close();
                        tcpClient.Close();
                        backgroundWorker.ReportProgress(0, Encoding.Unicode.GetString(data));
                    }
                    catch (Exception ex)
                    {
                        backgroundWorker.ReportProgress(0, "Error:" + ex.Message);
                    }
                }
            }
            catch (Exception e)
            {
                backgroundWorker.ReportProgress(0, "Error:" + e.Message);
            }

        } 

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            StartListener();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listBoxMessage.Items.Add(e.UserState.ToString() + "     Time:" + DateTime.Now.ToShortTimeString());
        }

        private void FrmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClose)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                backgroundWorker.CancelAsync();
                backgroundWorkerTcp.CancelAsync();
                listener.Close();
                tcpListener.Stop();
            }
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isClose = true;
            this.Close();
        }

        private void FrmClient_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Close();
            }
        }

        //接收远程控制包
        private void backgroundWorkerTcp_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    Byte[] bytes = new Byte[1024];
                    TcpClient client = tcpListener.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    do
                    {
                        stream.Read(bytes, 0, bytes.Length);
                    }
                    while (stream.DataAvailable);

                    ExecCommand(Encoding.Unicode.GetString(bytes, 0, bytes.Length).Replace("\0", "").Trim());
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                backgroundWorkerTcp.ReportProgress(0, "Error:" + ex.Message);
            }
        }

        private void ExecCommand(string command)
        {
            if (command == "Reboot")
            {
                Reboot();
                //backgroundWorkerTcp.ReportProgress(0, command);
            }
            else if (command == "PowerOff")
            {
                PowerOff();
                //backgroundWorkerTcp.ReportProgress(0, command);
            }
            else if (command == "LogoOff")
            {
                LogoOff();
                //backgroundWorkerTcp.ReportProgress(0, command);
            }
            else
            {
                MessageBox.Show(command);
            }
        }

        private void backgroundWorkerTcp_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listBoxMessage.Items.Add(e.UserState.ToString() + "     Time:" + DateTime.Now.ToShortTimeString());
        }
    }
}
