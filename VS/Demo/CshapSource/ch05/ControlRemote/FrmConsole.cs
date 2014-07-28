using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Xml;

namespace ControlRemote
{
    public partial class FrmConsole : Form
    {
        //UDP端口
        private const int UDPPORT = 8002;
        //TCP监听端口
        private const int TCPPORT = 8003;
        //TCP发送端口
        private const int TCPSENDPORT = 8004;
        //包内容分隔符
        private const string FGF = "|";
        //xml文件路径
        private const string XMLFILE = "eKanBan.conf";

        private UdpClient udpClient;
        private TcpListener tcpListener;
        private TcpClient tcpClient;
        private FrmMessage frmMessage;
        private XmlDocument xmlDocument;

        public FrmConsole()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化电子看板列表
            xmlDocument = new XmlDocument();
            xmlDocument.Load(XMLFILE);
            XmlNodeList xnl = xmlDocument.GetElementsByTagName("client");
            foreach (XmlNode node in xnl)
            {
                Button button = new Button();
                button.AutoSize = true;
                button.Text = node.Attributes["name"].Value;
                button.Name = node.Attributes["ipAddress"].Value;
                button.Tag = node.Attributes["macAddress"].Value;
                button.Image = Properties.Resources.Boomy_012;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.ContextMenuStrip = contextMenuStrip1;
                button.Click += new EventHandler(button_Click);
                flowLayoutPanel1.Controls.Add(button);
            }
            //启动TCP监听
            tcpListener = new TcpListener(Dns.GetHostAddresses(Dns.GetHostName())[0], TCPPORT);
            tcpListener.Start();
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
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

                    backgroundWorker.ReportProgress(9999, Encoding.Unicode.GetString(bytes, 0, bytes.Length).Trim());
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.ReportProgress(0, "Error:" + ex.Message);
            }
        }

        private void execCommand(string command)
        {
            Button button = new Button();
            button.AutoSize = true;
            button.Text = command.Substring(0, command.IndexOf(FGF));
            button.Name = command.Substring(command.IndexOf(FGF) + 1, command.LastIndexOf(FGF) - command.IndexOf(FGF) - 1);
            button.Tag = command.Substring(command.LastIndexOf(FGF) + 1, command.Length - command.LastIndexOf(FGF) - 1).Replace(":", "").Replace("\0", "");
            button.Image = Properties.Resources.Boomy_012;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.ContextMenuStrip = contextMenuStrip1;
            button.Click += new EventHandler(button_Click);
            flowLayoutPanel1.Controls.Add(button);

            XmlNode xn;
            if ((xn = xmlDocument.GetElementsByTagName("Clients")[0]) != null)
            {
                XmlNode xnChild = xmlDocument.CreateNode(XmlNodeType.Element, "", "client", "");
                XmlAttribute xa = xmlDocument.CreateAttribute("name");
                xa.Value = button.Text;
                xnChild.Attributes.Append(xa);

                xa = xmlDocument.CreateAttribute("ipAddress");
                xa.Value = button.Name;
                xnChild.Attributes.Append(xa);

                xa = xmlDocument.CreateAttribute("macAddress");
                xa.Value = button.Tag.ToString();
                xnChild.Attributes.Append(xa);

                xn.AppendChild(xnChild);
                xmlDocument.Save(XMLFILE);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (e.ProgressPercentage == 9999)
                {
                    execCommand(e.UserState.ToString());       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void button_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Tag = sender;
            contextMenuStrip1.Show((Button)sender, 10, 10);
        }
        private void FrmConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker.CancelAsync();
            tcpListener.Stop();
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void 搜索客户端RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (xmlDocument.GetElementsByTagName("Clients").Count > 0)
            {
                xmlDocument.GetElementsByTagName("Clients")[0].RemoveAll();
            }

            sendUdpCommand(IPAddress.Broadcast, UDPPORT, Dns.GetHostAddresses(Dns.GetHostName())[0].ToString() + FGF + TCPPORT.ToString(), true, "搜索电子看板");
        }

        // 发送UDP命令
        // </summary>
        // <param name="ipAddress">接收端IP</param>
        // <param name="portNum">接收端端口号</param>
        // <param name="command">发送内容</param>
        // <param name="isShowMessageBox">是否显示消息框</param>
        // <param name="context">消息内容</param>
        private void sendUdpCommand(IPAddress ipAddress, int portNum, string command, bool isShowMessageBox, string context)
        {
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, portNum);
            Byte[] sendBytes = Encoding.Unicode.GetBytes(command);
            try
            {
                udpClient = new UdpClient();
                udpClient.Send(sendBytes, sendBytes.Length, ipEndPoint);
                if (isShowMessageBox)
                {
                    frmMessage = new FrmMessage(context);
                    frmMessage.ShowDialog();
                }
                udpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void WakeUp(byte[] mac)
        {
            try
            {
                udpClient = new UdpClient();
                udpClient.Connect(IPAddress.Broadcast, 30000);
                byte[] packet = new byte[17 * 6];
                for (int i = 0; i < 6; i++)
                    packet[i] = 0xFF;

                for (int i = 1; i <= 16; i++)
                    for (int j = 0; j < 6; j++)
                        packet[i * 6 + j] = mac[j];

                int result = udpClient.Send(packet, packet.Length);
                udpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 远程关机ToolStripMenuItem_Click(object sender, EventArgs e)
        {          
        }
        private void 远程唤醒ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

        private void SendTcpCommand(string remoteIp, int portNum, string command)
        {
            try
            {
                tcpClient = new TcpClient(remoteIp, 8004);
                NetworkStream ns = tcpClient.GetStream();
                byte[] data = Encoding.Unicode.GetBytes(command);
                ns.Write(data, 0, data.Length);
                ns.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 远程注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = (Button)contextMenuStrip1.Tag;
            SendTcpCommand(button.Name, TCPSENDPORT, "LogoOff");
        }
        private void 远程重启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = (Button)contextMenuStrip1.Tag;
            SendTcpCommand(button.Name, TCPSENDPORT, "Reboot");
        }
        private void 远程关机ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Button button = (Button)contextMenuStrip1.Tag;
            SendTcpCommand(button.Name, TCPSENDPORT, "PowerOff");
        }
        private void 远程唤醒ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Button button = (Button)contextMenuStrip1.Tag;
            byte[] mac = StringConvertBytesMAC(button.Tag.ToString());
            WakeUp(mac);
        }

        private byte[] StringConvertBytesMAC(string macStr)
        {
            if (macStr.Length != 12 || (macStr.Length % 2) == 1)
            {
                throw new Exception("无效的MAC地址");
            }
            else
            {
                byte[] mac = new byte[6];
                int i = 0;
                while (macStr.Length > 0)
                {
                    string tmp = macStr.Substring(0, 2);
                    mac[i] = Convert.ToByte(tmp, 16);
                    i++;
                    macStr = macStr.Substring(2, macStr.Length - 2);
                }
                return mac;
            }
        }

        private void 发送消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = (Button)contextMenuStrip1.Tag;
            FrmInput frmInput = new FrmInput();
            if (frmInput.ShowDialog() == DialogResult.OK)
            {
                SendTcpCommand(button.Name, TCPSENDPORT, "管理员发送：" + frmInput.InputMessage + "\r\nTime:" + DateTime.Now.ToShortTimeString());
            }
        }
        private void 远程发送消息QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInput frmInput = new FrmInput();
            if (frmInput.ShowDialog() == DialogResult.OK)
            {
                System.Net.IPAddress ipAddress = System.Net.IPAddress.Broadcast;
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, UDPPORT);
                Byte[] sendBytes = Encoding.Unicode.GetBytes(frmInput.InputMessage);
                try
                {
                    udpClient = new UdpClient();
                    udpClient.Send(sendBytes, sendBytes.Length, ipEndPoint);
                    udpClient.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
