using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;

namespace ch5_3
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;

        //初始化代表访问历史纪录的数组
		private  string[] path={"","","",""};
		//代表目前进行操作的菜单项索引
		private  int index=0;
		//代表存储访问历史纪录的文件路径
		private  string filePath;

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
			this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
			this.SuspendLayout();
			// 
			// axShockwaveFlash1
			// 
			this.axShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axShockwaveFlash1.Enabled = true;
			this.axShockwaveFlash1.Name = "axShockwaveFlash1";
			this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
			this.axShockwaveFlash1.Size = new System.Drawing.Size(392, 273);
			this.axShockwaveFlash1.TabIndex = 0;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem9,
																					  this.menuItem10});
			this.menuItem1.Text = "文件 (&F)";
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
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem11,
																					  this.menuItem12,
																					  this.menuItem13,
																					  this.menuItem14});
			this.menuItem3.Text = "最近";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "1";
			this.menuItem11.Visible = false;
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = "2";
			this.menuItem12.Visible = false;
			this.menuItem12.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "3";
			this.menuItem13.Visible = false;
			this.menuItem13.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 3;
			this.menuItem14.Text = "4";
			this.menuItem14.Visible = false;
			this.menuItem14.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "-";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.Text = "退出(&X)";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8});
			this.menuItem4.Text = "控制(&C)";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "播放";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "重放";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 2;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Checked = true;
			this.menuItem8.Index = 3;
			this.menuItem8.Text = "循环";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.axShockwaveFlash1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Flash播放器";
			this.Closed += new System.EventHandler(this.Form1_Closed);
			((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
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

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog oDialog= new OpenFileDialog();
			//设置过滤器
			oDialog.Filter="Flash动画(*.swf)|*.swf|所有文件(*.*)|*.*";
			if (oDialog.ShowDialog()==DialogResult.OK)
			{
			  //播放选定的falsh
			  string fileName=oDialog.FileName;
			  this.axShockwaveFlash1.Movie=fileName;
    		  this.axShockwaveFlash1.Play();

			  //改变菜单名
			  this.menuItem3.MenuItems[index].Text=fileName;
			  //让菜单项可见
			  this.menuItem3.MenuItems[index].Visible=true;
			  //改变数组记录
			  this.path[index]=fileName;
			  //改变菜单项索引
			  index++;
              if (index==4)
			  {
			  index=0;
			  }
    		}



		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
		    this.Close();
			Application.Exit();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
		    this.axShockwaveFlash1.Play();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			this.axShockwaveFlash1.Rewind();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			//改变axShockwaveFlash1的loop状态
			if (this.axShockwaveFlash1.Loop==true)
			{
				this.axShockwaveFlash1.Loop=false;
				this.menuItem8.Checked=false;
			}
			else
			{
				this.axShockwaveFlash1.Loop=true;
				this.menuItem8.Checked=true;
			}
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			//得到发出信息的子菜单
			MenuItem item=(MenuItem)sender;
			//得到它的索引
			int index=item.Index;
			//得到路径
			string fileName=this.path[index];
			//播放动画
			this.axShockwaveFlash1.Movie=fileName;
			this.axShockwaveFlash1.Play();
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
		   
			if (this.filePath!=null)
			{
				StreamWriter sWriter=new StreamWriter(this.filePath,false,System.Text.Encoding.Default);
			
				foreach (string s in this.path)
				{
					sWriter.WriteLine(s);
				}
				sWriter.Close();
			}

		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			if (this.filePath!=null)
			{
				//新建一个写文件流
				StreamWriter sWriter=new StreamWriter(this.filePath,false,System.Text.Encoding.Default);
				//将历史记录数组的内容全部写入文件
				foreach (string s in this.path)
				{
					sWriter.WriteLine(s);
				}
				//关闭文件流
				sWriter.Close();
			}
			//退出程序
			Application.Exit();
		}
	}
}
