using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Games;
using System.Threading;

namespace rxsg
{

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入服务器地址","错误");
                return;
            }

            sgForm sgFrm = new sgForm();

            sgFrm.passUrl = this.textBox1.Text.Trim();

            sgFrm.Show();
            
            this.Hide();

            //sgFrm.sg.HookNetwork();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
