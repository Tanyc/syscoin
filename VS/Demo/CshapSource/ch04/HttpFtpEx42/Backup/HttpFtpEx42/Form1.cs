using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;//网络功能
using System.IO;//流支持
using System.Threading ;//线程支持  

namespace HttpFtpEx42
{
    public partial class Form1 : Form
    {
        public bool[] threadw; //每个线程结束标志
        public string[] filenamew;//每个线程接收文件的文件名
        public int[] filestartw;//每个线程接收文件的起始位置
        public int[] filesizew;//每个线程接收文件的大小
        public string strurl;//接受文件的URL
        public bool hb;//文件合并标志
        public int thread;//进程数

        public Form1()
        {
            InitializeComponent();
        }

        public void hbfile()
        {
            while (true)//等待
            {
                hb=true;
                for (int i=0;i< thread;i++)
                {
                    if (threadw[i]==false)//有未结束线程，等待
                    {
                        hb=false;
                        Thread.Sleep (100);
                        break;
                    }
                }
                if (hb==true)//所有线程均已结束，停止等待，
                  　break;
            }
            FileStream fs;//开始合并
            FileStream fstemp;
            int readfile;
            byte[] bytes=new byte[512];
            fs = new FileStream(txtBoxLocalFile.Text.Trim().ToString(), System.IO.FileMode.Create);
            for (int k=0;k< thread;k++)
            {
                fstemp=new FileStream (filenamew[k],System.IO.FileMode .Open); 
                while (true)
                {
                    readfile=fstemp.Read (bytes,0,512);
                    if (readfile>0)
                        fs.Write (bytes,0,readfile);
                    else
                        break;
                }
                fstemp.Close ();
            }
            fs.Close ();
            DateTime dt=DateTime.Now;
            txtBoxTime.Text = dt.ToString();//结束时间
            MessageBox.Show ("接收完毕!!!");
        }  

        private void btnReceive_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;//开始接收时间
            txtBoxTime.Text = dt.ToString();
            strurl = txtBoxRecUrl.Text.Trim().ToString();
            HttpWebRequest request;
            long filesize=0;
            try
            {
                request=(HttpWebRequest)HttpWebRequest.Create (strurl);
                filesize=request.GetResponse().ContentLength;//取得目标文件的长度
                request.Abort ();
            }
            catch (Exception er)
            {
                MessageBox.Show (er.Message );
            }
            // 接收线程数
            thread = Convert.ToInt32(txtBoxThreadCount.Text.Trim().ToString());
            //根据线程数初始化数组
            threadw=new bool [thread];
            filenamew=new string [thread];
            filestartw=new int [thread];
            filesizew=new int[thread];//计算每个线程应该接收文件的大小
            int filethread=(int)filesize/thread;//平均分配
            int filethreade=filethread+(int)filesize%thread;//剩余部分由最后一个线程完成
            //为数组赋值
            for (int i=0;i< thread;i++)
            {
                threadw[i]=false;//每个线程状态的初始值为假
                filenamew[i]=i.ToString ()+".dat";//每个线程接收文件的临时文件名
                if (i< thread-1)
                {
                    filestartw[i]=filethread*i;//每个线程接收文件的起始点
                    filesizew[i]=filethread-1;//每个线程接收文件的长度
                }
                else
                {
                    filestartw[i]=filethread*i;
                    filesizew[i]=filethreade-1;
                }
            }
            //定义线程数组，启动接收线程
            Thread[] threadk=new Thread [thread];
            HttpFile[] httpfile=new HttpFile [thread];
            for (int j=0;j< thread;j++)
            {
                httpfile[j]=new HttpFile(this,j);
                threadk[j]=new Thread(new ThreadStart (httpfile[j].receive));
                threadk[j].Start ();
            }
            //启动合并各线程接收的文件线程
            Thread hbth=new Thread (new ThreadStart (hbfile));
            hbth.Start ();  
        }        
    }
}
