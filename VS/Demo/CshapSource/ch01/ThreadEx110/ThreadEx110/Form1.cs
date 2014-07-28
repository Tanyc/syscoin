using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;    //引入多线程命名空间


namespace ThreadEx102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread thread;

        private void btnStart_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(ThreadAddItem);
            //声明一个线程
            thread = new Thread(threadStart);
            //启动线程
            thread.Start();

        }

        private delegate void AddItem(); //定义一个线程委托

        public void ThreadAddItem()
        {
            AddItem AddIt = new AddItem(Threading);  //实例化一个委托
            this.Invoke(AddIt);  //在拥有此控件的基础窗体句柄的线程上执行指定的委托
        }
        //自定义一个方法Threading，主要用于委托的调用
        public void Threading()
        {
            for (int index = 0; index < 100000; index++)
            {
                this.lstTest.Items.Add(string.Format("Item {0}", index));
            }
            thread.Abort();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("ListBox中一共有{0}项", this.lstTest.Items.Count));
        }

    }
}
