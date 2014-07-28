using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadEx104
{    
    public partial class Form1 : Form
    {
        StringBuilder sb = new StringBuilder();
        Thread thread1;
        Thread thread2;

        private void AppendString(string s)
        {
            lock (sb)
            {
                sb.Append(s);
            }
        }
        public void Method1()
        {
            while (true)
            {
                Thread.Sleep(100);   //线程休眠100毫秒
                AppendString("a");
            }
        }
        public void Method2()
        {
            while (true)
            {
                Thread.Sleep(100);   //线程休眠100毫秒
                AppendString("b");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sb.Remove(0, sb.Length);
            timer1.Enabled = true;
            thread1 = new Thread(new ThreadStart(Method1));
            thread2 = new Thread(new ThreadStart(Method2));
            thread1.Start();
            thread2.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread1.Join(10);
            thread2.Abort();
            thread2.Join(10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thread1.IsAlive == true || thread2.IsAlive == true)
            {
                richTextBox1.Text = sb.ToString();
            }
            else
            {
                timer1.Enabled = false;
            }

        }

     
    }
}
