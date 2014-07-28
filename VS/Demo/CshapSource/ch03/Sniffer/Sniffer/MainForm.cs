using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Net.Sockets;
using System.Threading;

namespace Sniffer
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// MainForm构造函数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 主窗体载入事件处理方法
        /// </summary>
        /// <param name="sender">主窗体对象</param>
        /// <param name="e">事件参数对象</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //如果在创建某控件的线程之外的其他线程试图调用该控件，
            //则调试器会引发一个 InvalidOperationException，
            //并提示消息：“从不是创建控件 control name 的线程访问它。”
            //可以通过将 CheckForIllegalCrossThreadCalls 属性的值设置为 false 来禁用此异常。
            System.Windows.Forms.ListView.CheckForIllegalCrossThreadCalls = false;

            //初始化lvSniffInfo控件的列信息
            lvSniffInfo.Columns.Add("协议", 50, System.Windows.Forms.HorizontalAlignment.Center);
            lvSniffInfo.Columns.Add("源地址", 100, System.Windows.Forms.HorizontalAlignment.Center);
            lvSniffInfo.Columns.Add("目的地址", 100, System.Windows.Forms.HorizontalAlignment.Center);
            lvSniffInfo.Columns.Add("源端口", 50, System.Windows.Forms.HorizontalAlignment.Center);
            lvSniffInfo.Columns.Add("目的端口", 80, System.Windows.Forms.HorizontalAlignment.Center);
            lvSniffInfo.Columns.Add("时间", 150, System.Windows.Forms.HorizontalAlignment.Center);

            //需添加System.Management引用
            string sqlStr = "SELECT * FROM Win32_NetworkAdapterConfiguration";
            ManagementObjectSearcher query1 =
                new ManagementObjectSearcher(sqlStr);//搜寻WMI类别
            ManagementObjectCollection queryCollection1 = query1.Get();//获取各种管理对象集合
            string[] IPString = new string[10];
            int x = 0;
            string[] temp;
            mySniffSocket = new SniffSocket();

            foreach (ManagementObject mo in queryCollection1)//获取本地的网络配置
            {
                temp = mo["IPAddress"] as string[];
                if (temp != null)
                {
                    foreach (string st in temp)
                    {
                        IPString[x] = st;
                        x++;
                    }
                }
            }

            for (int y = 0; y < x; y++)//为组合框添加列表项
            {
                if (IPString[y] != "")
                    cmbIpList.Items.Add(IPString[y]);
            }

            cmbIpList.Text = cmbIpList.Items[0] as string;

            try
            {
                mySniffSocket.CreateAndBindSocket(cmbIpList.Text);//创建和绑定Socket连接
            }
            catch (SniffSocket.SniffSocketException ex)
            {
                MessageBox.Show(this, ex.Message);

            }
            mySniffSocket.PacketArrival += 
                new SniffSocket.PacketArrivedEventHandler(DataArrival);//绑定事件处理方法 
        }

        /// <summary>
        /// 单击[开如捕获]按钮事件处理方法
        /// </summary>
        /// <param name="sender">[开始捕获]按钮</param>
        /// <param name="e">事件参数对象</param>
        private void btnStart_Click(object sender, EventArgs e){
            if (mySniffSocket.KeepRunning == false){
                mySniffSocket.KeepRunning = true;
                try{
                    mySniffSocket.Run();//开始监听
                } catch (SocketException){//如果监听出现异常，将重新创建和绑定连接
                    mySniffSocket.CreateAndBindSocket(cmbIpList.Text);
                    mySniffSocket.Run();
                }
                btnStart.Text = "暂停";
            } else {
                mySniffSocket.KeepRunning = false;
                btnStart.Text = "恢复";
            } 
        }

        /// <summary>
        /// 单击[结束捕获]按钮事件处理方法
        /// </summary>
        /// <param name="sender">[结束捕获]按钮</param>
        /// <param name="e">事件参数对象</param>
        private void btnClose_Click(object sender, EventArgs e)
        {

            mySniffSocket.KeepRunning = false;
            btnStart.Text = "开始";
            Thread.Sleep(10);//需要引用System.Threading
            mySniffSocket.ShutDown(); //禁止Socket上的发送和接收

        }

        /// <summary>
        /// 单击[清除]按钮事件处理方法
        /// </summary>
        /// <param name="sender">[清除]按钮</param>
        /// <param name="e">事件参数对象</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lvSniffInfo.Items.Clear();
            txtPacketInfo.Text = "";

        }

        /// <summary>
        /// 单击lvSniffInfo控件中的一个列表项事件处理方法
        /// </summary>
        /// <param name="sender">lvSniffInfo控件</param>
        /// <param name="e">事件参数对象</param>
        private void lvSniffInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSniffInfo.SelectedItems.Count != 0)
            {
                foreach (ListViewItem item in lvSniffInfo.SelectedItems) {                    
                    txtPacketInfo.Text = item.SubItems[6].Text;
                }
                 
            }
        }

        private SniffSocket mySniffSocket;

        /// <summary>
        /// 事件处理方法
        /// </summary>
        /// <param name="sender">引发事件对象</param>
        /// <param name="e">事件参数</param>
        private void DataArrival(object sender, SniffSocket.PacketArrivedEventArgs e)
        {

            String str = "";
            foreach (byte b in e.MessageBuffer)//处理数据包中的消息(十六进制显示)
            {
                str += b.ToString("x") + "\t";
            }

            String[] data = new String[] {e.Protocol.ToString(),
                e.OriginationAddress.ToString(),
                e.DestinationAddress.ToString(),
                e.OriginationPort.ToString(),
                e.DestinationPort.ToString(),
                e.Date.ToString(),
                str};

            lvSniffInfo.Items.Add(new ListViewItem(data));//将基本信息添加到列表框中

        }
    }
}
