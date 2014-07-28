using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Threading;
using System.Net.Sockets;
using System.IO;


namespace ch7_2
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.StatusBar statusBar1;
        
		//代表监听的线程
		private Thread listenThread;
		//代表监听的状态
		private bool listen=false;
        //代表网络监听的对象
		private TcpListener tcpListener;

		private System.Windows.Forms.RichTextBox richTextBox2;

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;



		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(16, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(272, 40);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "目标地址";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 24);
			this.button1.TabIndex = 3;
			this.button1.Text = "准备接收";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(190, 56);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "停止接收";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "请输入姓名";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(224, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "发送";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label1,
																					this.textBox1,
																					this.button1,
																					this.button2});
			this.groupBox1.Location = new System.Drawing.Point(16, 192);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 96);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 303);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(296, 22);
			this.statusBar1.TabIndex = 9;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(16, 88);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(272, 96);
			this.richTextBox2.TabIndex = 10;
			this.richTextBox2.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox2,
																		  this.statusBar1,
																		  this.groupBox1,
																		  this.button3,
																		  this.textBox2,
																		  this.label2,
																		  this.richTextBox1});
			this.Name = "Form1";
			this.Text = "点对点聊天";
			this.Closed += new System.EventHandler(this.Form1_Closed);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//改变按钮状态
			button1.Enabled = false;
			button2.Enabled = true;
			//创建监听线程
			listenThread = new Thread(new ThreadStart(StartListen));	
			//启动线程
			listenThread.Start();
		}

		private void StartListen()
		{
			try
			{
				tcpListener = new TcpListener(5675);
				//开始监听
				tcpListener.Start();
				//改变状态栏 
				statusBar1.Text = "正在监听...";
				//设置监听状态
				this.listen=true;
                
				while(listen)
				{
//					//接受连接请求
//					Socket s = tcpListener.AcceptSocket();
//                    //设置一个缓冲区
//					Byte[] stream = new Byte[100];
//					int i=s.Receive(stream) ;
//					//将获得的流转化为字符串类型
//					string message = System.Text.Encoding.UTF8.GetString(stream);
//					this.richTextBox2.AppendText(message);
					//获取TcpClient
					TcpClient s=tcpListener.AcceptTcpClient();
					NetworkStream nc=s.GetStream();
					byte[] bytes = new byte[1024];
					int bytesRead=nc.Read(bytes,0,bytes.Length);
					string message=System.Text.Encoding.Default.GetString(bytes,0,bytesRead);
					this.richTextBox2.AppendText(message);
				}
			}
			//错误处理
			catch 
			{
				//忽略错误处理
				//改变状态栏
				statusBar1.Text = "已停止监听！";
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		   //改变按钮状态
		   this.button1.Enabled=true;
		   this.button2.Enabled=false;
		   //改变监听状态
		   this.listen=false;
		   //停止监听器
		   this.tcpListener.Stop();
		   //停止监听线程
		   this.listenThread.Abort();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				//获得消息
				string msg = "<"+this.textBox2.Text+">"+this.richTextBox1.Text+"\n";
				//根据目标计算机地址建立连接
				TcpClient tcpClient = new TcpClient(textBox1.Text, 5675);
				//获得用于网络访问的数据流
				NetworkStream tcpStream = tcpClient.GetStream();

				StreamWriter streamW = new StreamWriter(tcpStream);
				//将字符串写入流
				streamW.Write(msg);
				//将缓冲数据写入基础流
				streamW.Flush();
				//关闭网络流
				tcpStream.Close();
				//关闭
				tcpClient.Close();
 
				this.richTextBox2.AppendText(msg);
				this.richTextBox1.Clear();
			}
			catch
			{
			
				statusBar1.Text =  "目标计算机拒绝连接请求！";
			}
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
			if (this.tcpListener!=null)
			{
				//关闭监听器
				this.tcpListener.Stop();
			}
			if (this.listenThread!=null)
			{
				//如果线程还处于运行状态就关闭它
				if (this.listenThread.ThreadState==ThreadState.Running)
				{
					this.listenThread.Abort();
				}
			}
		}
	}
}
