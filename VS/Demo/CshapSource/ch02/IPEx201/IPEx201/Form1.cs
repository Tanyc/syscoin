using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace IPEx201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = Dns.GetHostName();
            listBox1.Items.Add("本机主机名：" + name);
            IPHostEntry me = Dns.GetHostEntry(name);
            listBox1.Items.Add("本机所有IP地址：");
            foreach (IPAddress ip in me.AddressList)
            {
                listBox1.Items.Add(ip);
            }
            IPAddress localip = IPAddress.Parse("127.0.0.1");
            IPEndPoint iep = new IPEndPoint(localip, 80);
            listBox1.Items.Add("The IPEndPoint is: " + iep.ToString());
            listBox1.Items.Add("The Address is: " + iep.Address);
            listBox1.Items.Add("The AddressFamily is: " + iep.AddressFamily);
            listBox1.Items.Add("The max port number is: " + IPEndPoint.MaxPort);
            listBox1.Items.Add("The min port number is: " + IPEndPoint.MinPort);

        }

        private void btnRemote_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            IPHostEntry remoteHost = Dns.GetHostEntry("www.sohu.com");
            IPAddress[] remoteIP = remoteHost.AddressList;
            listBox1.Items.Add("搜狐网站：");
            foreach (IPAddress ip in remoteIP)
            {
                IPEndPoint iep = new IPEndPoint(ip, 80);
                listBox1.Items.Add(iep);
            }
        }
    }
}
