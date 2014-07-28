using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;         //三个名称空间的引用
using System.Net.Sockets;
using System.Threading;

namespace TCPServerEx202
{

    public partial class Form1 : Form
    {
        private Socket socket;
        private Socket clientSocket;
        Thread thread;

        public Form1()
        {
            InitializeComponent();

            this.ServerState.Items.Clear();  //初始化界面控件
            this.AcceptMess.Text = "";
            this.SendMessage.Text = "";
            this.ServerIP.Text = "127.0.0.1";
            this.ListePort.Text = "6888";
        }

        private void AccepMessage()   //添加的新方法
        {
            NetworkStream netStream = new NetworkStream(clientSocket);
            while (true)
            {
                try
                {
                    byte[] datasize = new byte[4];
                    netStream.Read(datasize, 0, 4);
                    int size = System.BitConverter.ToInt32(datasize, 0);
                    Byte[] message = new byte[size];
                    int dataleft = size;
                    int start = 0;
                    while (dataleft > 0)
                    {
                        int recv = netStream.Read(message, start, dataleft);
                        start += recv;
                        dataleft -= recv;
                    }
                    this.AcceptMess.Rtf = System.Text.Encoding.Unicode.GetString(message);
                }
                catch
                {
                    this.ServerState.Items.Add("与客户断开连接");
                    break;
                }
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            IPAddress ip = IPAddress.Parse(this.ServerIP.Text);
            IPEndPoint server = new IPEndPoint(ip, Int32.Parse(this.ListePort.Text));
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(server);
            //监听客户端连接
            socket.Listen(10);
            clientSocket = socket.Accept();
            //显示客户IP和端口号
            this.ServerState.Items.Add("与客户 " + clientSocket.RemoteEndPoint.ToString() + " 建立连接");
            //创建一个线程接收客户信息
            thread = new Thread(new ThreadStart(AccepMessage));
            thread.Start();
        }
        
        private void btnSendMes_Click(object sender, EventArgs e)
        {
            string str = this.SendMessage.Rtf;
            int i = str.Length;
            if (i == 0)
            {
                return;
            }
            else
            {
                //因为str为Unicode编码，每个字符占2字节，所以实际字节数应*2
                i *= 2;
            }
            byte[] datasize = new byte[4];
            //将32位整数值转换为字节数组
            datasize = System.BitConverter.GetBytes(i);
            byte[] sendbytes = System.Text.Encoding.Unicode.GetBytes(str);
            try
            {
                NetworkStream netStream = new NetworkStream(clientSocket);
                netStream.Write(datasize, 0, 4);
                netStream.Write(sendbytes, 0, sendbytes.Length);
                netStream.Flush();
                this.SendMessage.Rtf = "";
            }
            catch
            {
                MessageBox.Show("无法发送!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = true;
            try
            {
                socket.Close();
                if (clientSocket.Connected)
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    thread.Abort();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
