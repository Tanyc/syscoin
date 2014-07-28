using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading; //引入多线程命名空间

namespace ThreadEx101
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(AddItem);

            Thread thread = new Thread(threadStart);  //声明一个线程

            thread.Start();   //启动线程

        }

        private void AddItem()
        {
            for (int index = 0; index < 100000; index++)
            {
                this.lstTest.Items.Add(string.Format("Item {0}", index));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("ListBox中一共有{0}项", this.lstTest.Items.Count));
        }

    }
}
