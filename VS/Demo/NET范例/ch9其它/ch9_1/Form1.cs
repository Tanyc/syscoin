using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch9_1
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private AxAgentObjects.AxAgent axAgent1;
		private AgentObjects.IAgentCtlCharacterEx Character;
		private string agent;


		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button chooseButton;
		private System.Windows.Forms.Button activeButton;
		private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.MainMenu mainMenu1;
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
		//	comboBox1.SelectedIndex=0;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.axAgent1 = new AxAgentObjects.AxAgent();
			this.activeButton = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.confirmButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chooseButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			((System.ComponentModel.ISupportInitialize)(this.axAgent1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// axAgent1
			// 
			this.axAgent1.Enabled = true;
			this.axAgent1.Location = new System.Drawing.Point(248, 320);
			this.axAgent1.Name = "axAgent1";
			this.axAgent1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAgent1.OcxState")));
			this.axAgent1.Size = new System.Drawing.Size(32, 32);
			this.axAgent1.TabIndex = 0;
			this.axAgent1.ClickEvent += new AxAgentObjects._AgentEvents_ClickEventHandler(this.axAgent1_ClickEvent);
			this.axAgent1.DblClick += new AxAgentObjects._AgentEvents_DblClickEventHandler(this.axAgent1_DblClick);
			// 
			// activeButton
			// 
			this.activeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.activeButton.Location = new System.Drawing.Point(40, 72);
			this.activeButton.Name = "activeButton";
			this.activeButton.Size = new System.Drawing.Size(75, 24);
			this.activeButton.TabIndex = 1;
			this.activeButton.Text = "激活精灵";
			this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "Genie",
														   "Merlin",
														   "Peedy",
														   "Robby"});
			this.comboBox1.Location = new System.Drawing.Point(120, 32);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "Genie";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(320, 96);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "请写入您的提示内容";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label2,
																					this.numericUpDown1,
																					this.label1});
			this.groupBox1.Location = new System.Drawing.Point(24, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 72);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "设置定时提醒";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(200, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "分钟";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(104, 32);
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(80, 21);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(56, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "等待";
			// 
			// confirmButton
			// 
			this.confirmButton.Enabled = false;
			this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.confirmButton.Location = new System.Drawing.Point(64, 344);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(75, 24);
			this.confirmButton.TabIndex = 7;
			this.confirmButton.Text = "确定";
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.chooseButton,
																					this.comboBox1,
																					this.activeButton});
			this.groupBox2.Location = new System.Drawing.Point(24, 208);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(272, 104);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "选择精灵";
			// 
			// chooseButton
			// 
			this.chooseButton.Enabled = false;
			this.chooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chooseButton.Location = new System.Drawing.Point(152, 72);
			this.chooseButton.Name = "chooseButton";
			this.chooseButton.Size = new System.Drawing.Size(75, 24);
			this.chooseButton.TabIndex = 3;
			this.chooseButton.Text = "重新选择";
			this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Location = new System.Drawing.Point(176, 344);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 24);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "退出";
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 397);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.exitButton,
																		  this.groupBox2,
																		  this.confirmButton,
																		  this.groupBox1,
																		  this.textBox1,
																		  this.axAgent1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "精灵提醒";
			((System.ComponentModel.ISupportInitialize)(this.axAgent1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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



		private void activeButton_Click(object sender, System.EventArgs e)
		{
			//得到精灵名称
			string s=comboBox1.SelectedItem.ToString();
			this.agent=s;
			//根据用户的选择导入精灵
			switch (s)
			{ 		
				case "Genie":
					//导入具体的精灵 
					axAgent1.Characters.Load("Genie", (object)"GENIE.ACS");
					Character = axAgent1.Characters["Genie"];
					break;
				case "Merlin":
					axAgent1.Characters.Load("Merlin", (object)"MERLIN.ACS");
					Character = axAgent1.Characters["Merlin"]; 
					break;
				case "Peedy":
					axAgent1.Characters.Load("Peedy", (object)"PEEDY.ACS");
					Character = axAgent1.Characters["Peedy"];
					break;
				case "Robby":
					axAgent1.Characters.Load("Robby", (object)"ROBBY.ACS");
					Character = axAgent1.Characters["Robby"]; 
					break;
				
			}
			//显示精灵 
			Character.Show(null);
			//改变其他button的状态
	        this.activeButton.Enabled=false;
			this.chooseButton.Enabled=true;
			this.confirmButton.Enabled=true;
		}

		private void chooseButton_Click(object sender, System.EventArgs e)
		{
	
		//精灵动作停止
		this.Character.Stop(null);
		//卸载导入的精灵
		this.axAgent1.Characters.Unload(agent);
		//改变其他按钮的状态
		this.activeButton.Enabled=true;
		this.chooseButton.Enabled=false;
		this.confirmButton.Enabled=false;
		}

		private void axAgent1_ClickEvent(object sender, AxAgentObjects._AgentEvents_ClickEvent e)
		{
  		    //显示主窗体
			this.Visible=true;
		}

		private void confirmButton_Click(object sender, System.EventArgs e)
		{
			//隐藏窗体
			this.Visible=false;
			//隐藏精灵
			this.Character.Hide(null);
			//确定隐藏时间
			int i=(int)this.numericUpDown1.Value*60*1000;
			//等待
			System.Threading.Thread.Sleep(1000);
			//显示精灵
			this.Character.Show(null);
			string s=this.textBox1.Text;
			//精灵说话
			Character.Speak(s,null);
		}

		private void exitButton_Click(object sender, System.EventArgs e)
		{
		    //关闭窗体，退出程序
			this.Close();
			Application.Exit();
		}

		private void axAgent1_DblClick(object sender, AxAgentObjects._AgentEvents_DblClickEvent e)
		{
			this.Visible=true;
		}

		
	
	}
}
