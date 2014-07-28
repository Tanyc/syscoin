using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Microsoft.Win32;
using System.IO;

namespace ch4_5
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(24, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 64);
			this.label1.TabIndex = 1;
			this.label1.Text = "你想开机就自动启动这个窗体？";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(144, 128);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "取消";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 213);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.label1,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "自动启动的窗体";
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
		    //如果确定将启动信息写入注册表
			if (MessageBox.Show("你确定开机就要启动这个程序吗？","提示",MessageBoxButtons.OKCancel)==
				DialogResult.OK)
			{
				//获得文件的当前路径
				string dir=Directory.GetCurrentDirectory();
				//获取可执行文件的全部路径
				string exeDir=dir+"\\ch4_5.exe";

				//获取Run键
				RegistryKey key1=Registry.LocalMachine;
				RegistryKey key2=key1.CreateSubKey("SOFTWARE");
				RegistryKey key3=key2.CreateSubKey("Microsoft");
				RegistryKey key4=key3.CreateSubKey("Windows");
				RegistryKey key5=key4.CreateSubKey("CurrentVersion");
				RegistryKey key6=key5.CreateSubKey("Run");
				//在Run键中写入一个新的键值
				key6.SetValue("myForm",exeDir);
	
      		}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//如果确定将启动信息删除
			if (MessageBox.Show("你确定要删除注册表中的信息吗？","提示",MessageBoxButtons.OKCancel)==
				DialogResult.OK)
			{
			   	
				//获取Run键
				RegistryKey key1=Registry.LocalMachine;
				RegistryKey key2=key1.CreateSubKey("SOFTWARE");
				RegistryKey key3=key2.CreateSubKey("Microsoft");
				RegistryKey key4=key3.CreateSubKey("Windows");
				RegistryKey key5=key4.CreateSubKey("CurrentVersion");
				RegistryKey key6=key5.CreateSubKey("Run");
				//删除键值
				key6.DeleteValue("myForm",false);
	
			}
		}
	}
}
