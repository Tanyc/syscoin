using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreadEx101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < 100000; index++)
            {
                this.lstTest.Items.Add(string.Format("Item {0}", index));
            }

        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("ListBox中一共有{0}项", this.lstTest.Items.Count));
        }
    }
}
