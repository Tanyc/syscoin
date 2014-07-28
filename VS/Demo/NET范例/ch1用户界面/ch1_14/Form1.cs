using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_14
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenu = this.contextMenu1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "这是一个演示将程序图标停放在任务栏上的测试程序";
			this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "退出";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.button1.Location = new System.Drawing.Point(8, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(256, 64);
			this.button1.TabIndex = 0;
			this.button1.Text = "将窗体隐藏到系统任务栏上";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 64);
			this.label1.TabIndex = 1;
			this.label1.Text = "    这是一个演示将程序图标停放在任务栏上的测试程序。";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(280, 229);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.button1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "演示图标程序";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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
		    this.Visible=false;
			//使得notifyIcon控件显示在任务栏上
			this.notifyIcon1.Visible=true;
		}

		private void notifyIcon1_Click(object sender, System.EventArgs e)
		{
			//显示窗体
			this.Visible=true;
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			//退出程序
			this.notifyIcon1.Visible=false;
			this.Close();
			Application.Exit();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//指示取消关闭事件
			e.Cancel=true;
			this.Visible=false;
			////使得notifyIcon控件显示在任务栏上
			this.notifyIcon1.Visible=true;
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			this.Visible=false;
			////使得notifyIcon控件显示在任务栏上
			this.notifyIcon1.Visible=true;
		}

		
	
	}
}
