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
using System.Collections;

namespace AsyncTcpServerEx204
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }

        ArrayList friends = new ArrayList();  //保存与客户相关的信息的列表
        TcpListener listener;                      //负责侦听的套接字
        bool IsStart = false;                      //指示是否已经启动了侦听
        //对控件进行调用的委托类型和委托方法
        //在列表中写字符串
        delegate void AppendDelegate(string str);
        AppendDelegate AppendString;
        //在建立连接时，往下拉列表框中添加客户信息
        delegate void AddDelegate(MyFriend frd);
        AddDelegate Addfriend;
        //在断开连接时，从下拉列表框中删除客户信息
        delegate void RemoveDelegate(MyFriend frd);
        RemoveDelegate Removefriend;
        //在列表中写字符串的委托方法
        private void AppendMethod(string str)
        {
            lstBoxStatu.Items.Add(str);
            lstBoxStatu.SelectedIndex = lstBoxStatu.Items.Count - 1;
            lstBoxStatu.ClearSelected();
        }
        //往下拉列表框中添加信息的委托方法
        private void AddMethod(MyFriend frd)
        {
            lock (friends)
            { friends.Add(frd); }
            comboBoxClient.Items.Add(frd.socket.RemoteEndPoint.ToString());
        }
        //从下拉列表框中删除信息的委托方法
        private void RemoveMethod(MyFriend frd)
        {
            int i = friends.IndexOf(frd);
            comboBoxClient.Items.RemoveAt(i);
            lock (friends) { friends.Remove(frd); }
            frd.Dispose();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            //实例化委托对象，与委托方法关联
            AppendString = new AppendDelegate(AppendMethod);
            Addfriend = new AddDelegate(AddMethod);
            Removefriend = new RemoveDelegate(RemoveMethod);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //服务器已经其中侦听，则返回
            if (IsStart) return;
            //服务器启动侦听
            IPEndPoint localep = new IPEndPoint(Dns.GetHostAddresses(Dns.GetHostName())[0], 11000);
            listener = new TcpListener(localep);
            listener.Start(10);
            IsStart = true;
            lstBoxStatu.Invoke(AppendString, string.Format("服务器已经启动侦听！端点为：{0}。", listener.LocalEndpoint.ToString()));
            //接受连接请求的异步调用
            AsyncCallback callback = new AsyncCallback(AcceptCallback);
            listener.BeginAcceptSocket(callback, listener);
            this.btnStart.Enabled = false;
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                //完成异步接受连接请求的异步调用
                //将连接信息添加到列表和下拉列表框中
                Socket handle = listener.EndAcceptSocket(ar);
                MyFriend frd = new MyFriend(handle);
                comboBoxClient.Invoke(Addfriend, frd);
                AsyncCallback callback;
                //继续调用异步方法接收连接请求
                if (IsStart)
                {
                    callback = new AsyncCallback(AcceptCallback);
                    listener.BeginAcceptSocket(callback, listener);
                }
                //开始在连接上进行异步的数据接收
                frd.ClearBuffer();
                callback = new AsyncCallback(ReceiveCallback);
                frd.socket.BeginReceive(frd.Rcvbuffer, 0, frd.Rcvbuffer.Length, SocketFlags.None, callback, frd);
            }
            catch
            {
                //listBox1.Invoke(AppendString,exception
                //在调用EndAcceptSocket方法时可能引发异常
                //——套接字Listener被关闭，则设置为未启动侦听状态
                IsStart = false;
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            MyFriend frd = (MyFriend)ar.AsyncState;
            try
            {
                int i = frd.socket.EndReceive(ar);

                if (i == 0)
                {
                    comboBoxClient.Invoke(Removefriend, frd);
                    return;
                }
                else
                {
                    string data = Encoding.UTF8.GetString(frd.Rcvbuffer, 0, i);
                    data = string.Format("From[{0}]:{1}", frd.socket.RemoteEndPoint.ToString(), data);
                    lstBoxStatu.Invoke(AppendString, data);

                    frd.ClearBuffer();
                    AsyncCallback callback = new AsyncCallback(ReceiveCallback);
                    frd.socket.BeginReceive(frd.Rcvbuffer, 0, frd.Rcvbuffer.Length, SocketFlags.None, callback, frd);
                }
            }
            catch //(Exception ex)
            {
                comboBoxClient.Invoke(Removefriend, frd);
            }
        }

        private void SendData(MyFriend frd, string data)
        {
            try
            {
                byte[] msg = Encoding.UTF8.GetBytes(data);
                AsyncCallback callback = new AsyncCallback(SendCallback);
                frd.socket.BeginSend(msg, 0, msg.Length, SocketFlags.None, callback, frd);
                data = string.Format("To[{0}]:{1}", frd.socket.RemoteEndPoint.ToString(), data);
                lstBoxStatu.Invoke(AppendString, data);
            }
            catch
            {
                comboBoxClient.Invoke(Removefriend, frd);
            }
        }

        private void SendCallback(IAsyncResult ar)
        {
            MyFriend frd = (MyFriend)ar.AsyncState;
            try
            {
                frd.socket.EndSend(ar);
            }
            catch
            {
                comboBoxClient.Invoke(Removefriend, frd);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!IsStart) return;
            listener.Stop();
            IsStart = false;
            lstBoxStatu.Invoke(AppendString, "已经结束了服务器的侦听！");
            this.btnStart.Enabled = true;
        }

        private void btnSendMes_Click(object sender, EventArgs e)
        {
            if (txtBoxMessag.Text.Trim() == "")
            {
                lstBoxStatu.Items.Add("不能发送空字符串！");
                txtBoxMessag.Focus();
                return;
            }
            if (comboBoxClient.SelectedIndex < 0)
            {
                lstBoxStatu.Items.Add("请在列表框中选择发送对象！");
                return;
            }
            int i = comboBoxClient.SelectedIndex;
            SendData((MyFriend)friends[i], txtBoxMessag.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lstBoxStatu.Items.Clear();
        }
    }
}
