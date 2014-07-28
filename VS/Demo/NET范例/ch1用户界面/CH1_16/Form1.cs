using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CH1_16
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
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
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolTip1
			// 
			this.toolTip1.Active = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Image = ((System.Drawing.Bitmap)(resources.GetObject("button1.Image")));
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(16, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(16, 16);
			this.button1.TabIndex = 0;
			this.toolTip1.SetToolTip(this.button1, "我的电脑");
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Image = ((System.Drawing.Bitmap)(resources.GetObject("button2.Image")));
			this.button2.ImageIndex = 2;
			this.button2.ImageList = this.imageList1;
			this.button2.Location = new System.Drawing.Point(64, 24);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(16, 16);
			this.button2.TabIndex = 1;
			this.toolTip1.SetToolTip(this.button2, "电子邮件");
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Image = ((System.Drawing.Bitmap)(resources.GetObject("button3.Image")));
			this.button3.ImageIndex = 1;
			this.button3.ImageList = this.imageList1;
			this.button3.Location = new System.Drawing.Point(40, 24);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(16, 16);
			this.button3.TabIndex = 2;
			this.toolTip1.SetToolTip(this.button3, "电话");
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Image = ((System.Drawing.Bitmap)(resources.GetObject("button4.Image")));
			this.button4.ImageIndex = 3;
			this.button4.ImageList = this.imageList1;
			this.button4.Location = new System.Drawing.Point(88, 24);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(16, 16);
			this.button4.TabIndex = 3;
			this.toolTip1.SetToolTip(this.button4, "时钟");
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Image = ((System.Drawing.Bitmap)(resources.GetObject("button5.Image")));
			this.button5.ImageIndex = 4;
			this.button5.ImageList = this.imageList1;
			this.button5.Location = new System.Drawing.Point(112, 24);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(16, 16);
			this.button5.TabIndex = 4;
			this.toolTip1.SetToolTip(this.button5, "软盘");
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Image = ((System.Drawing.Bitmap)(resources.GetObject("button6.Image")));
			this.button6.ImageIndex = 5;
			this.button6.ImageList = this.imageList1;
			this.button6.Location = new System.Drawing.Point(136, 24);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(16, 16);
			this.button6.TabIndex = 5;
			this.toolTip1.SetToolTip(this.button6, "记事本");
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(40, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "启用工具提示";
			this.toolTip1.SetToolTip(this.checkBox1, "是否启用工具提示");
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(176, 24);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(120, 40);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "始终显示提示";
			this.toolTip1.SetToolTip(this.checkBox2, "如果选中,当窗体不活动时也能显示工具提示");
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "200",
														   "500",
														   "1000",
														   "2000"});
			this.comboBox1.Location = new System.Drawing.Point(176, 80);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 5;
			this.toolTip1.SetToolTip(this.comboBox1, "设置工具提示的自动延迟");
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
														   "1000",
														   "5000",
														   "10000",
														   "20000"});
			this.comboBox2.Location = new System.Drawing.Point(176, 120);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 20);
			this.comboBox2.TabIndex = 6;
			this.toolTip1.SetToolTip(this.comboBox2, "设置工具提示保持的时间");
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Items.AddRange(new object[] {
														   "50",
														   "100",
														   "500",
														   "1000"});
			this.comboBox3.Location = new System.Drawing.Point(176, 160);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 20);
			this.comboBox3.TabIndex = 7;
			this.toolTip1.SetToolTip(this.comboBox3, "设置鼠标指针从一个控件移到另一控件时，后面的“工具提示”窗口出现前必须经过多长时间");
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button6,
																				 this.button5,
																				 this.button4,
																				 this.button3,
																				 this.button2,
																				 this.button1});
			this.panel1.Location = new System.Drawing.Point(8, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 64);
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.comboBox3,
																					this.comboBox2,
																					this.comboBox1,
																					this.label3,
																					this.label2,
																					this.label1,
																					this.checkBox2,
																					this.checkBox1});
			this.groupBox1.Location = new System.Drawing.Point(8, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 208);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "工具提示设置";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "工具提示再现的时延";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "工具提示的保持时间";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "工具提示的自动延迟";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(360, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.panel1});
			this.Name = "Form1";
			this.Text = "带工具提示的控件";
			this.panel1.ResumeLayout(false);
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

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			//设置工具提示控件的状态
			this.toolTip1.Active=this.checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
    		//如果为true,当窗体不活动时也能显示工具提示
		
			this.toolTip1.ShowAlways=this.checkBox1.Checked;

		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//设置工具提示的自动延迟
			int s=Int32.Parse(this.comboBox1.SelectedItem.ToString());
			this.toolTip1.AutomaticDelay=s;
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		    //设置工具提示保持的时间
			int s=Int32.Parse(this.comboBox2.SelectedItem.ToString());
		    this.toolTip1.AutoPopDelay=s;
		}

		private void comboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//设置鼠标指针从一个控件移到另一控件时，后面的“工具提示”窗口出现前必须经过多长时间
		    int s=Int32.Parse(this.comboBox3.SelectedItem.ToString());
			this.toolTip1.ReshowDelay=s;
		}

		
	}
}
