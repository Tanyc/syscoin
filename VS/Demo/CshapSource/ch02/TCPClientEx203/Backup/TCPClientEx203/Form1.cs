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

namespace TCPClientEx203
{
    public partial class Form1 : Form
    {
        private Socket socket;
        private Thread thread;

        public Form1()
        {
            InitializeComponent();

            this.rchTxtBoxSend.Text = "";    //初始化界面控件
            this.rchTxtBoxReceive.Text = "";
            this.lstBoxState.Items.Clear();
            this.txtBoxIP.Text = "127.0.0.1";
            this.txtBoxPort.Text = "6888";
        }

        private void AccepMessage()
        {
            NetworkStream netStream = new NetworkStream(socket);
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
                    this.rchTxtBoxReceive.Rtf = System.Text.Encoding.Unicode.GetString(message);
                }
                catch
                {
                    break;
                }
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            IPEndPoint server = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6888);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(server);
            }
            catch
            {
                MessageBox.Show("与服务器连接失败！");
                return;
            }
            this.btnRequest.Enabled = false;
            this.lstBoxState.Items.Add("与服务器连接成功");
            thread = new Thread(new ThreadStart(AccepMessage));
            thread.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = this.rchTxtBoxSend.Rtf;
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
                NetworkStream netStream = new NetworkStream(socket);
                netStream.Write(datasize, 0, 4);
                netStream.Write(sendbytes, 0, sendbytes.Length);
                netStream.Flush();
                this.rchTxtBoxSend.Text = "";
            }
            catch
            {
                MessageBox.Show("无法发送!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (socket.Connected)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    thread.Abort();
                }
                this.lstBoxState.Items.Add("与主机断开连接");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            this.btnRequest.Enabled = true;
        }
    }
}
