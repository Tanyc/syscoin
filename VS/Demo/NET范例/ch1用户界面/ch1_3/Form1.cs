using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_3
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.Button button1;
		private Form2 form2Example;
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
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(80, 168);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(144, 32);
			this.button3.TabIndex = 5;
			this.button3.Text = "隐藏窗体";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(80, 104);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 32);
			this.button2.TabIndex = 4;
			this.button2.Text = "显示窗体";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "新建窗体";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button3,
																		  this.button2,
																		  this.button1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "主窗体";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void button3_Click(object sender, System.EventArgs e)
		{
			//使窗体隐藏
			form2Example.Visible=false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			form2Example= new Form2();
			//创建一个窗体后，Button2,Button3就可以使用了，而Button1不再使用
			button1.Enabled=false;
			button2.Enabled=true;
			button3.Enabled=true;
			form2Example.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//使窗体可见
			form2Example.Visible=true;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//设置窗体的位置和大小
			Rectangle pos= new Rectangle(250,250,300,300);
			this.Bounds=pos;
		}
	}
}
