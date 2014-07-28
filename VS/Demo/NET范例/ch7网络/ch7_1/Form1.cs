using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Net;
using System.Net.Sockets;

namespace ch7_1
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox1;

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
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "主机名称";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "IP地址";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(24, 136);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 192);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "获取";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(120, 192);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(120, 21);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "textBox3";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(264, 261);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBox3,
																		  this.button1,
																		  this.textBox2,
																		  this.label2,
																		  this.textBox1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "获取IP地址";
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
			//获取本地主机名称
			string host=Dns.GetHostName();
			this.textBox1.Text=host;
           
			IPHostEntry ipHostEntry=Dns.GetHostByName(Dns.GetHostName());
			//获得本机IP地址
			IPAddress addr = new IPAddress ( ipHostEntry.AddressList [0].Address ) ;
			this.textBox2.Text=addr.ToString();
          
			
			
		}
	}
}
