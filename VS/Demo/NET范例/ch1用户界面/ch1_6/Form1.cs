using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_6
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.TabPage tabPage3;
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2,
																					  this.tabPage3});
			this.tabControl1.Location = new System.Drawing.Point(16, 16);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(328, 112);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(320, 87);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(320, 87);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 21);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(320, 87);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.groupBox3,
																					this.groupBox2,
																					this.tabControl1});
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 432);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label4,
																					this.button3,
																					this.button2,
																					this.textBox1,
																					this.label3});
			this.groupBox3.Location = new System.Drawing.Point(16, 144);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(328, 96);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "添加删除选项卡";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 64);
			this.label4.Name = "label4";
			this.label4.TabIndex = 4;
			this.label4.Text = "删除当前选项卡";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(232, 64);
			this.button3.Name = "button3";
			this.button3.TabIndex = 3;
			this.button3.Text = "确定";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 24);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "确定";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(120, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			this.label3.Text = "添加一个选项卡";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.checkBox3,
																					this.button1,
																					this.checkBox2,
																					this.checkBox1,
																					this.comboBox1,
																					this.label2,
																					this.label1});
			this.groupBox2.Location = new System.Drawing.Point(16, 256);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(328, 168);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "tabControl设置";
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(24, 96);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(88, 16);
			this.checkBox3.TabIndex = 7;
			this.checkBox3.Text = "HotTrack";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 96);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(224, 56);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(64, 24);
			this.checkBox2.TabIndex = 4;
			this.checkBox2.Text = "否";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(160, 56);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(56, 24);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "是";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "Normal",
														   "Buttons",
														   "FlatButtons"});
			this.comboBox1.Location = new System.Drawing.Point(160, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "Normal";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "是否多行显示选项卡";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "选项卡按钮外观";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "tabControl示例";
			this.tabControl1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			//设置选项卡是否是多行显示
			if (checkBox1.Checked==true)
			{
				tabControl1.Multiline=true;
			}
			else
			{
			    tabControl1.Multiline=false; 
			}
			//选择选项卡的外观
			switch (comboBox1.SelectedItem.ToString())
			{
				case "Normal":
					tabControl1.Appearance=TabAppearance.Normal;
					break;
				case "FlatButtons":
                    tabControl1.Appearance=TabAppearance.FlatButtons;
					break;
				case "Buttons":
					tabControl1.Appearance=TabAppearance.Buttons;
					break;
			}
		   //设置HotTrack选项
			tabControl1.HotTrack=checkBox3.Checked;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			//保证只能选定一个checkBox
			if (checkBox1.Checked==true){
			checkBox2.Checked=false;
			}
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			//保证只能选定一个checkBox
			if (checkBox2.Checked==true)
			{
			checkBox1.Checked=false;
			}
		}
       
		private void button2_Click(object sender, System.EventArgs e)
		{
            string tabpagename = textBox1.Text;
			//如果textBox里面没有输入，则发出一个警告
			if (tabpagename==""){
			MessageBox.Show("请输入选项卡名称");
			}
			else
			{
			   //新建一个Tabpage类的实例
				TabPage newtabpage=new TabPage(tabpagename);
               //添加一个新的选项卡
			   tabControl1.TabPages.Add(newtabpage);
			}
		}
     
		private void button3_Click(object sender, System.EventArgs e)
		{
			  //删除当前的选项卡
			tabControl1.TabPages.Remove(tabControl1.SelectedTab);
		}

		private void groupBox3_Enter(object sender, System.EventArgs e)
		{
		
		}

	}
}
