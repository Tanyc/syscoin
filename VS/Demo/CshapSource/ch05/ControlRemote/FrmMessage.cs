using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlRemote
{
    public partial class FrmMessage : Form
    {
        private const int TIMEOUT = 50;
        private int timeCount = 0;

        public FrmMessage(string message)
        {
            InitializeComponent();
            lbMessage.Text = message;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeCount < TIMEOUT)
            {
                timeCount++;
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }

        private void FrmMessage_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
