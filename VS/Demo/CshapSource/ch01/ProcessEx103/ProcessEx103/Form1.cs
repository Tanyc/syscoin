using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace ProcessEx103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "notepad.exe";

            process1.Start(); //启动Notepad.exe进程.

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Process[] myprocesses;  //创建新的Process组件的数组,并将它们与指定的进程名称（Notepad）的所有进程资源相关联
            myprocesses = Process.GetProcessesByName("Notepad");
            foreach (Process instance in myprocesses)
            {
                //设置终止当前线程前等待1000毫秒
                instance.WaitForExit(1000);
                instance.CloseMainWindow();
            }

        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Process[] processes;  //创建Process类型的数组,并将它们与系统内所有进程相关联
            processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                this.listBox1.Items.Add(p.ProcessName);//将每个进程名加入listBox1中
            }
        }
    }
}
