using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch5_1
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private AxMediaPlayer.AxMediaPlayer axMediaPlayer1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.axMediaPlayer1 = new AxMediaPlayer.AxMediaPlayer();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 18);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "打开";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button2,
																					this.textBox1,
																					this.button1});
			this.groupBox1.Location = new System.Drawing.Point(8, 336);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 56);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(336, 18);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "播放";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(208, 21);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "文件(&F)";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "打开(&O)";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "退出(&X)";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// axMediaPlayer1
			// 
			this.axMediaPlayer1.AllowDrop = true;
			this.axMediaPlayer1.Location = new System.Drawing.Point(8, 0);
			this.axMediaPlayer1.Name = "axMediaPlayer1";
			this.axMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMediaPlayer1.OcxState")));
			this.axMediaPlayer1.Size = new System.Drawing.Size(456, 320);
			this.axMediaPlayer1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(472, 405);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.axMediaPlayer1,
																		  this.groupBox1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "媒体播放器";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).EndInit();
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
			OpenFileDialog ofDialog=new OpenFileDialog();
			ofDialog.Filter="Window Media文件(*.asf;*.wm;*.wma)|*.asf;*.wm;*.wma|媒体播放表(*.asx;*.wax;*.m3u;*.wvx)|*.asx;*.wax;*.m3u;*.wvx|电影文件(MPEG)(*.mpeg;*.mpg)|*.mpeg;*.mpg|视频文件(*.avi;*.wmv)|*.avi;*.wmv|所有文件(*.*)|*.*";

			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
				try
				{
					string mediaPath=ofDialog.FileName;
					axMediaPlayer1.FileName=mediaPath;
					axMediaPlayer1.Play();
					this.textBox1.Text=mediaPath;
				}

				catch
				{
					MessageBox.Show("无法播放此文件","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
			
				}
		
			}
		}

		protected override void OnMouseEnter( EventArgs e)
		{
			string i="";
		this.axMediaPlayer1.DoDragDrop(i ,DragDropEffects.None);
	
		}

		protected override void  OnDragEnter( DragEventArgs drgEvent)
		{
			string s=drgEvent.Data.ToString();
			int i=1 ;
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (this.textBox1.Text!="")
			{
				try
				{
					//获得文件名
					string mediaPath=this.textBox1.Text;
					//设置播放文件名
					axMediaPlayer1.FileName=mediaPath;
					//播放文件
					axMediaPlayer1.Play();
				}
				catch
				{
					//错误信息
					MessageBox.Show("无法播放此文件","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
			
				}
			}
			else
			{
				MessageBox.Show("请输入播放文件名称","警告",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			//退出程序
			this.Close();
			Application.Exit();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofDialog=new OpenFileDialog();
			//设置过滤器
			ofDialog.Filter="Window Media文件(*.asf;*.wm;*.wma)|*.asf;*.wm;*.wma|媒体播放表(*.asx;*.wax;*.m3u;*.wvx)|*.asx;*.wax;*.m3u;*.wvx|电影文件(MPEG)(*.mpeg;*.mpg)|*.mpeg;*.mpg|视频文件(*.avi;*.wmv)|*.avi;*.wmv|所有文件(*.*)|*.*";
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
				try
				{
			        //获得文件名
					string mediaPath=ofDialog.FileName;
					//设置播放文件名
					axMediaPlayer1.FileName=mediaPath;
					//播放文件
					axMediaPlayer1.Play();
					this.textBox1.Text=mediaPath;
				}

				catch
				{
					//错误信息
					MessageBox.Show("无法播放此文件","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);		
				}	
			}
		}
	}
}
