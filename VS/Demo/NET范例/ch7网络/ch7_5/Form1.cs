using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ch7_5
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "请输入网址";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(224, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(24, 120);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(224, 21);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "选择保存文件";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(176, 80);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "浏览";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(176, 168);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "下载";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(280, 221);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.button1,
																		  this.label2,
																		  this.textBox2,
																		  this.textBox1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "网页下载";
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
			SaveFileDialog sDialog=new SaveFileDialog();
			sDialog.Filter="网页(*.htm;*.html)|*.htm;*.html";
            //显示保存文件对话框
			if (sDialog.ShowDialog()==DialogResult.OK)
			{
            //得到保存文件名
			this.textBox2.Text=sDialog.FileName;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (this.textBox2.Text!="")
			{
				//得到保存文件名
				string fileName=this.textBox2.Text.Trim();
				//得到运程主机名
				string hostName=this.textBox1.Text.Trim();
				//得到主机信息 
				IPHostEntry ipInfo=Dns.GetHostByName(hostName); 
				//取得IPAddress地址列表
				IPAddress[] ipAddr=ipInfo.AddressList; 
				//得到ip 
				IPAddress ip=ipAddr[0]; 

				//组合出远程终结点 
				IPEndPoint hostEP=new IPEndPoint(ip,80);
				//创建Socket 实例 
				Socket socket=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp); 

				try 
				{ 
					//尝试连接 
					socket.Connect(hostEP); 
				} 
				catch(Exception se) 
				{ 
					MessageBox.Show("连接错误"+se.Message,"提示信息"
						,MessageBoxButtons.RetryCancel,MessageBoxIcon.Information); 
				} 

				//发送给远程主机的请求内容串 
				string sendStr="GET / HTTP/1.1\r\nHost: " + hostName + 
					"\r\nConnection: Close\r\n\r\n"; 
			
				//创建bytes字节数组以转换发送串 
				byte[] bytesSendStr=new byte[1024]; 
				//将发送内容字符串转换成字节byte数组 
				bytesSendStr=System.Text.Encoding.Default.GetBytes(sendStr); 
			
				try 
				{ 
					//向主机发送请求 
    				socket.Send(bytesSendStr,bytesSendStr.Length,0); 
			
				} 
				catch(Exception ce) 
				{ 
					MessageBox.Show("发送错误:"+ce.Message,"提示信息 "
						,MessageBoxButtons.RetryCancel,MessageBoxIcon.Information); 
				} 


				//声明接收返回内容的字符串 
				string receiveStr=""; 
				//声明字节数组，一次接收数据的长度为1024字节 
				byte[] receiveBytes=new byte[1024]; 
				//返回实际接收内容的字节数 
				int bytes=0; 
				//循环读取，直到接收完所有数据 
				while(true) 
				{ 
					bytes=socket.Receive(receiveBytes,receiveBytes.Length,0); 
					//读取完成后退出循环 
					if(bytes<=0) 
						break; 
					//将读取的字节数转换为字符串 
					receiveStr+=System.Text.Encoding.Default.GetString(receiveBytes,0,bytes); 
				} 
				//将所读取的字符串转换为字节数组 
				string s=receiveStr.Substring(receiveStr.IndexOf("<"));
				byte[] content=System.Text.Encoding.Default.GetBytes(s); 

				try 
				{ 
					//创建文件流对象实例 
					FileStream fs=new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite); 
					//写入文件 
					fs.Write(content,0,content.Length); 
                    //保存成功提示
					MessageBox.Show("保存网页成功","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information); 
		
				} 
				catch(Exception fe) 
				{ 
					MessageBox.Show("文件创建/写入错误:"+fe.Message,"提示信息",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information); 
				}
  
				//禁用Socket 
				socket.Shutdown(SocketShutdown.Both); 
				//关闭Socket 
				socket.Close(); 

			}
			else
			{
				MessageBox.Show("请输入网址","提示",MessageBoxButtons.OK,MessageBoxIcon.Information); 
		
			}
		}
	}
}
