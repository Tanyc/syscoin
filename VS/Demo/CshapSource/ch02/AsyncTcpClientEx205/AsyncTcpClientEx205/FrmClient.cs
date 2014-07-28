using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;           //引入的名称空间
using System.Net.Sockets;
using System.Threading;

namespace AsyncTcpClientEx205
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        Socket client = null;
        byte[] Rcvbuffer;
        string Sendstr;

        delegate void AppendDelegate(string str);
        AppendDelegate AppendString;

        private void AppendMethod(string str)
        {
            lstBoxMessage.Items.Add(str);
        }
        
        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                //Socket client1 = (Socket)ar.AsyncState;
                client.EndConnect(ar);
                lstBoxMessage.Invoke(AppendString, String.Format("已经成功连接到服务器{0}！", client.RemoteEndPoint.ToString()));
                lstBoxMessage.Invoke(AppendString, String.Format("本地端接点为{0}！", client.LocalEndPoint.ToString()));
                Rcvbuffer = new byte[client.SendBufferSize];
                AsyncCallback callback = new AsyncCallback(ReceiveCallback);
                client.BeginReceive(Rcvbuffer, 0, Rcvbuffer.Length, SocketFlags.None, callback, client);
            }
            catch
            {
                lstBoxMessage.Invoke(AppendString, String.Format("无法建立与服务器的连接！"));
            }
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                int i = client.EndReceive(ar);
                string data = string.Format("收：{0}", Encoding.UTF8.GetString(Rcvbuffer, 0, i));
                lstBoxMessage.Invoke(AppendString, data);

                Rcvbuffer = new byte[client.SendBufferSize];
                AsyncCallback callback = new AsyncCallback(ReceiveCallback);
                client.BeginReceive(Rcvbuffer, 0, Rcvbuffer.Length, SocketFlags.None, callback, client);
            }
            catch (Exception ex)
            {
                if (client != null)
                {
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                    client = null;
                    lstBoxMessage.Invoke(AppendString, ex.Message);
                }
            }
        }      

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (client == null) return;
            if (!client.Connected) return;
            client.Shutdown(SocketShutdown.Both);
            client.Close(50);
            client = null;
            lstBoxMessage.Items.Add("断开了到服务器的TCP连接！");
        }

        private void SendData()
        {
            try
            {
                byte[] msg = Encoding.UTF8.GetBytes(Sendstr);
                AsyncCallback callback = new AsyncCallback(SendCallback);
                client.BeginSend(msg, 0, msg.Length, SocketFlags.None, callback, client);
            }
            catch
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                client = null;
                lstBoxMessage.Invoke(AppendString, "服务器断开了TCP连接！");
            }
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                client.EndSend(ar);
                lstBoxMessage.Invoke(AppendString, string.Format("发：{0}", Sendstr));
            }
            catch
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                client = null;
                lstBoxMessage.Invoke(AppendString, "服务器断开了TCP连接！");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtBoxSendMess.Text.Trim() == "")
            {
                lstBoxMessage.Items.Add("不能发送空字符串！");
                txtBoxSendMess.Focus();
                return;
            }
            if (client == null)
            {
                lstBoxMessage.Items.Add("尚未建立到服务器的连接！");
                btnConnect.Focus();
                return;
            }
            if (!client.Connected)
            {
                lstBoxMessage.Items.Add("尚未建立到服务器的连接！");
                btnConnect.Focus();
                return;
            }
            Sendstr = txtBoxSendMess.Text.Trim();
            SendData();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            if (!client.Connected)
            {
                IPEndPoint remoteep = new IPEndPoint(Dns.GetHostAddresses(Dns.GetHostName())[0], 11000);
                AsyncCallback callback = new AsyncCallback(ConnectCallback);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.BeginConnect(remoteep, callback, client);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppendString = new AppendDelegate(AppendMethod);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lstBoxMessage.Items.Clear();
        }
    }
}
