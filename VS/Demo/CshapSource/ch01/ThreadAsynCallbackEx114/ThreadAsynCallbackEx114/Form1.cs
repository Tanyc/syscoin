using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace ThreadAsynCallbackEx114
{
    public partial class Form1 : Form
    {
        //private delegate void ThreadCurrentNumber(int tempCurrent, Label lb); //定义一个线程委托
        //ThreadCurrentNumber CurrentNumber1;

        //声明一个回调函数：注意传递的参数要与Example类中的函数参数类型一致
        public delegate void ExampleCallback(int lineCount, Label lb);

        public Form1()
        {
            InitializeComponent();
            //CurrentNumber1 = new ThreadCurrentNumber(CurrentNumber);
        }

        public void CurrentNumber(int tempCurrent, Label lb)
        {
            lb.Text = tempCurrent.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadWithData twd = new ThreadWithData(1, 100, this.label1, new ExampleCallback(CurrentNumber));
            Thread td = new Thread(new ThreadStart(twd.RunMethod));
            td.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreadWithData twd = new ThreadWithData(2, 200, this.label2, new ExampleCallback(CurrentNumber));
            Thread td = new Thread(new ThreadStart(twd.RunMethod));
            td.Start();
        }

        public class ThreadWithData
        {
            private int start = 0;
            private int end = 0;
            private ExampleCallback callBack;
            private Label lb;

            public ThreadWithData(int start, int end, Label lb, ExampleCallback callBack)
            {
                this.start = start;
                this.end = end;
                this.callBack = callBack;
                this.lb = lb;
            }
            public void RunMethod()
            {
                for (int i = start; i < end; i++)
                {
                    Thread.Sleep(500);
                    if (callBack != null)
                        callBack(i, lb);
                }

            }
        }

    }
}
