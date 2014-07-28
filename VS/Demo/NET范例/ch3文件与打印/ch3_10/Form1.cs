using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;

namespace ch3_10
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ProgressBar progressBar1;
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
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "真的要清空回收站吗?";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 64);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar1.Location = new System.Drawing.Point(0, 102);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(248, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(248, 125);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.progressBar1,
																		  this.button1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "清空回收站";
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
			//获取计算机上逻辑驱动器的名称
			string[] drivers=Directory.GetLogicalDrives();
			int i=drivers.Length;
            //初始化processBar
			this.progressBar1.Value=0;
		    //设定ProcessBar的步长
			this.progressBar1.Step=100/i;
            
			//对每个逻辑驱动器上的回收站都要清空
			foreach (string driver in drivers)
			{
				try
				{
					
					string[] sFiles=Directory.GetFiles(driver+"\\Recycled");
				    //首先清空回收站下单独的文件
					if (sFiles.Length!=0)
					{
						foreach (string sFile in sFiles)
						{
						File.Delete(sFile);
						} 
					}
                     
					string[] sDirectories=Directory.GetDirectories(driver+"\\Recycled");
					//清空回收站下的目录
					if (sDirectories.Length!=0)
					{
						foreach (string sDirectory in sDirectories)
						{
						Directory.Delete(sDirectory,true);
						}
					
					}
					//processBar的值增加一个步长
					this.progressBar1.PerformStep();

				}
				catch(Exception error)
				{
				//不加入任何的事件处理
				}
			}		
			//程序运行结束，ProcessBar也结束
	        this.progressBar1.Value=100;
		}

	}
}
