using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Microsoft.Win32;

namespace ch4_4
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button3;
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
            InitialComboBox();
			InitialForm1();
				//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}
         
		private void InitialComboBox()
		{
			//将FormBorderStyle枚举值读入到comboBox中去
			for (int i=0;i<7;i++)
			{
				this.comboBox1.Items.Add(((FormBorderStyle)i).ToString());
			}
			this.comboBox1.SelectedIndex=1;
		}

		private void InitialForm1()
		{
			//获取或者新建Form1主键
			RegistryKey  hLocalMachine=Registry.LocalMachine;
			RegistryKey  software=hLocalMachine.OpenSubKey("SOFTWARE",true);
			RegistryKey  newNode=software.CreateSubKey("Form1");
			//如果主键下面包含的子键数目不为0，则读取子键
			if (newNode.SubKeyCount!=0)
			{
				RegistryKey  formColor=newNode.CreateSubKey("formColor");
				//获取color键值
				string color=formColor.GetValue("color").ToString();
				RegistryKey  borderStyle=newNode.CreateSubKey("borderStyle");
				//获取borderStyle键值
				string style=borderStyle.GetValue("borderStyle").ToString();

				//根据color键值设定radioButton的checked属性
				if (color=="red") 
				{
					this.BackColor=Color.Red;
					this.radioButton1.Checked=true;
				}
				if (color=="yellow") 
				{
					this.BackColor=Color.Yellow;
					this.radioButton2.Checked=true;
				}
				//将string转化为int
				int i=Int32.Parse(style);
				//根据color的键值设定FormBorderStyle属性
				FormBorderStyle fStyle=(FormBorderStyle)i;
				this.FormBorderStyle=fStyle;
				this.comboBox1.SelectedIndex=i;			    
			}
			//如果主键下面包含的子键数目为0，则进行默认初始化
			else
			{
			this.radioButton3.Checked=true;
			this.comboBox1.SelectedIndex=1;
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.comboBox1,
																					this.label2,
																					this.radioButton3,
																					this.radioButton2,
																					this.radioButton1,
																					this.label1});
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "设置";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(136, 72);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(120, 20);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "窗体边框样式";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(216, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(32, 18);
			this.radioButton3.TabIndex = 3;
			this.radioButton3.Text = "无";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(168, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(32, 18);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "黄";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(112, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(48, 18);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.Text = "红";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "窗体背景颜色";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "写入注册表";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 160);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "恢复注册表";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(200, 160);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "退出";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 199);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "注册信息的创建和删除";
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			string  selectColor="none";
			if (this.radioButton1.Checked==true){selectColor="red";};
			if (this.radioButton2.Checked==true){selectColor="yellow";};
        	int fStyle=this.comboBox1.SelectedIndex;
		             
			//获得或创建代表Form1信息的节点
			RegistryKey  hLocalMachine=Registry.LocalMachine;
			RegistryKey  software=hLocalMachine.OpenSubKey("SOFTWARE",true);
			RegistryKey  newNode=software.CreateSubKey("Form1");
		
			//创建一个子键formColor
			RegistryKey  formColor=newNode.CreateSubKey("formColor");
			//设置一个叫color键的键值
			formColor.SetValue("color",selectColor);
        
			//创建一个子键borderStyle
			RegistryKey  borderStyle=newNode.CreateSubKey("borderStyle");
			//设置一个叫borderStyle的键值
			borderStyle.SetValue("borderStyle",fStyle);

			MessageBox.Show("已成功写入注册表","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show("您确定要删除写入的键值吗？","提示",
				MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
			{
				RegistryKey  hLocalMachine=Registry.LocalMachine;
				RegistryKey  software=hLocalMachine.OpenSubKey("SOFTWARE",true);
				RegistryKey  newNode=software.CreateSubKey("Form1");
				//删除子项和任何子级子项
				software.DeleteSubKeyTree("Form1");
                MessageBox.Show("已经成功删除写入的键值","提示",
				MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
			//不做任何处理
			}
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			//保证只有一个单选钮被选定
			if (this.radioButton1.Checked==true)
			{
			this.BackColor=Color.Red;
			this.radioButton2.Checked=false;
			this.radioButton3.Checked=false;
			}
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			//保证只有一个单选钮被选定
			if (this.radioButton2.Checked==true)
			{
				this.BackColor=Color.Yellow;
				this.radioButton1.Checked=false;
				this.radioButton3.Checked=false;
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			//保证只有一个单选钮被选定
			if (this.radioButton3.Checked==true)
			{
				this.BackColor=Color.Empty;
				this.radioButton1.Checked=false;
				this.radioButton2.Checked=false;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//改变窗体边框样式
			int i=this.comboBox1.SelectedIndex;
			FormBorderStyle fStyle=(FormBorderStyle)i;
			this.FormBorderStyle=fStyle;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//退出程序
			this.Close();
			Application.Exit();
		}
	}
}
