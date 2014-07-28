using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;

namespace ch4_3
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
		    	
			GetCpuInfo();
	

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void GetCpuInfo()
		{
		//获得代表CPU信息的节点
		RegistryKey  hLocalMachine=Registry.LocalMachine;
		RegistryKey  hardware=hLocalMachine.OpenSubKey("HARDWARE");
		RegistryKey  description=hardware.OpenSubKey("DESCRIPTION");
		RegistryKey  system=description.OpenSubKey("SYSTEM");
		RegistryKey  processor=system.OpenSubKey("CentralProcessor");
		RegistryKey  information=processor.OpenSubKey("0");


	    //获取主键中指定键的键值，并写入相应的Label控件
		this.label5.Text=information.GetValue("VendorIdentifier").ToString();
	    this.label6.Text=information.GetValue("ProcessorNameString").ToString();
	    this.label7.Text=information.GetValue("Identifier").ToString();
		this.label8.Text=information.GetValue("~MHz").ToString()+" MHz";	
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
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label8,
																					this.label7,
																					this.label6,
																					this.label5,
																					this.label4,
																					this.label3,
																					this.label2,
																					this.label1});
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "cpu 信息";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Location = new System.Drawing.Point(112, 128);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(192, 16);
			this.label8.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(112, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(192, 16);
			this.label7.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(112, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(192, 16);
			this.label6.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(112, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 16);
			this.label5.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "速度";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "标识";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "描述";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "制造商";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 221);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "cpu信息";
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

		
	}
}
