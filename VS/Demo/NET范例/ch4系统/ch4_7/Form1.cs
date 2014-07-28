using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

//using System.Diagnostics;
using System.ServiceProcess;

namespace ch4_7
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox listBox1;
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

			Information();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void Information()
		{
			//获取计算机名称
			this.label1.Text=SystemInformation.ComputerName;
			//获取用户名
			this.label2.Text=SystemInformation.UserName;
			//获取用户工作域名称
			this.label3.Text=SystemInformation.UserDomainName;
			//获取显示器分辨率
			this.label4.Text=SystemInformation.PrimaryMonitorSize.Width.ToString()+","+
				 SystemInformation.PrimaryMonitorSize.Height.ToString();
			
			//检查网络连接状态
			if (SystemInformation.Network==true)
			{
				this.label5.Text="已连接";
			}
			else
			{
			    this.label5.Text="未连接";
			}
			//获取启动模式
			this.label6.Text=SystemInformation.BootMode.ToString();

			//获取使用的操作系统的Platform和版本值
			this.label13.Text=Environment.OSVersion.Platform.ToString();
			this.label14.Text=Environment.OSVersion.Version.ToString();
            
			
			ServiceController[] services;
			//检索计算机上的所有服务
			services = ServiceController.GetServices();
			//将服务的名称添加到ListBox中
			for (int i = 0; i <  services.Length; i++)
			{
				this.listBox1.Items.Add(services[i].ServiceName);
			}



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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label16,
																					this.label15,
																					this.label14,
																					this.label13,
																					this.label12,
																					this.label11,
																					this.label10,
																					this.label9,
																					this.label8,
																					this.label7,
																					this.label6,
																					this.label5,
																					this.label4,
																					this.label3,
																					this.label2,
																					this.label1});
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(248, 288);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "系统信息";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(128, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(128, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(128, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(128, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(128, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(128, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "计算机名";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 16);
			this.label8.TabIndex = 7;
			this.label8.Text = "用户名";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 16);
			this.label9.TabIndex = 8;
			this.label9.Text = "用户域名称";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 120);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 16);
			this.label10.TabIndex = 9;
			this.label10.Text = "显示器分辨率";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 152);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 16);
			this.label11.TabIndex = 10;
			this.label11.Text = "网络连接";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 184);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 16);
			this.label12.TabIndex = 11;
			this.label12.Text = "启动方式";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Location = new System.Drawing.Point(128, 216);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 16);
			this.label13.TabIndex = 12;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label14.Location = new System.Drawing.Point(128, 248);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 16);
			this.label14.TabIndex = 13;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(16, 216);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(88, 16);
			this.label15.TabIndex = 14;
			this.label15.Text = "操作系统";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(16, 248);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 16);
			this.label16.TabIndex = 15;
			this.label16.Text = "系统版本";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.listBox1});
			this.groupBox2.Location = new System.Drawing.Point(280, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 288);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "系统服务";
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(16, 24);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(208, 244);
			this.listBox1.Sorted = true;
			this.listBox1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(536, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "获取系统信息";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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

		
	}
}
