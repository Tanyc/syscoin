using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadControlEx109
{
    public partial class Form1 : Form
    {
        Thread thread1;
        Thread thread2;
        delegate void AppendStringDelegate(string str);
        AppendStringDelegate appendStringDelegate;

        public Form1()
        {
            InitializeComponent();
            appendStringDelegate = new AppendStringDelegate(AppendString);
        }
        private void AppendString(string str)
        {
            richTextBox1.Text += str;
        }
        private void Method1()
        {
            while (true)
            {
                Thread.Sleep(100);   //线程1休眠100毫秒
                richTextBox1.Invoke(appendStringDelegate, "a");
            }
        }
        private void Method2()
        {
            while (true)
            {
                Thread.Sleep(100);   //线程2休眠100毫秒
                richTextBox1.Invoke(appendStringDelegate, "b");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            thread1 = new Thread(new ThreadStart(Method1));
            thread2 = new Thread(new ThreadStart(Method2));
            thread1.Start();
            thread2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread1.Join();
            thread2.Abort();
            thread2.Join();
            MessageBox.Show("线程1、2终止成功");
        }
    }
}
