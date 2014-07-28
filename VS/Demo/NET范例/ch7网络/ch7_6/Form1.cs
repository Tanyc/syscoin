using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ch7_6
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(32, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(208, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "trueice.dhs.org";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(32, 152);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(152, 104);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "浏览";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 192);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "保存";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "请输入网址";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "选择保存文件";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(272, 245);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.label1,
																		  this.button2,
																		  this.button1,
																		  this.textBox2,
																		  this.textBox1});
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
			//得到保存文件名
			string fileName=this.textBox2.Text.Trim();
			//得到网页名称
			string url=this.textBox1.Text.Trim();
	   
			//如果前面没有加"http://"标志则加上。
			if (url.IndexOf(@"http://")==-1 )
			{		
				url=@"http://"+url;
			}

			//构造Web请求
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			//发送请求，获取响应
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			//使用到的读写流
			Stream inStream = null;
			FileStream fileStream = null;
			try
			{
				//获得流
				inStream = response.GetResponseStream();
				//获得文件长度
				long fileSizeInBytes = response.ContentLength;
				//创建文件流对象
				fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
				//读取数据缓冲区长度和缓冲区
				int length = 1024;
				byte[] buffer = new byte[1025];
				//记录读取的长度
				int bytesread = 0;
				string s="";
				//从网络读取数据
				while((bytesread = inStream.Read(buffer, 0, length)) > 0)
				{
					//把数据写入文件
					fileStream.Write(buffer, 0, bytesread);
					s+=System.Text.Encoding.Default.GetString(buffer,0,bytesread);
				}
			}
			catch(Exception fe)
			{
				MessageBox.Show("文件创建/写入错误:"+fe.Message,"提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information); 
				
			}
			finally
			{
				//关闭流
				if(inStream != null)
				{
					inStream.Close();
				}
				if(fileStream != null)
				{
					fileStream.Close();
				}
			}

		}
	}
}
