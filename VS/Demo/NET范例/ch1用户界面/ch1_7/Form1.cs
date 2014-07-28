using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_7
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemSet;
		private System.Windows.Forms.MenuItem menuItemColor;
		private System.Windows.Forms.MenuItem menuItemBlue;
		private System.Windows.Forms.MenuItem menuItemRed;
		private System.Windows.Forms.MenuItem menuItemWhite;
		private System.Windows.Forms.MenuItem menuItemFont;
		private System.Windows.Forms.MenuItem menuItemSmall;
		private System.Windows.Forms.MenuItem menuItemMedium;
		private System.Windows.Forms.MenuItem menuItemLarge;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItemOpen;
		private System.Windows.Forms.MenuItem menuItemClose;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ContextMenu contextMenu2;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemSeparator;
        
		//创建一个关于字体大小的结构
		private struct FontSizes 
		{
			public static float Small = 8f;
			public static float Medium = 16f;
			public static float Large = 24f;
		}
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemOpen = new System.Windows.Forms.MenuItem();
			this.menuItemSeparator = new System.Windows.Forms.MenuItem();
			this.menuItemClose = new System.Windows.Forms.MenuItem();
			this.menuItemSet = new System.Windows.Forms.MenuItem();
			this.menuItemColor = new System.Windows.Forms.MenuItem();
			this.menuItemBlue = new System.Windows.Forms.MenuItem();
			this.menuItemRed = new System.Windows.Forms.MenuItem();
			this.menuItemWhite = new System.Windows.Forms.MenuItem();
			this.menuItemFont = new System.Windows.Forms.MenuItem();
			this.menuItemSmall = new System.Windows.Forms.MenuItem();
			this.menuItemMedium = new System.Windows.Forms.MenuItem();
			this.menuItemLarge = new System.Windows.Forms.MenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenu2 = new System.Windows.Forms.ContextMenu();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemFile,
																					  this.menuItemSet});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemOpen,
																						 this.menuItemSeparator,
																						 this.menuItemClose});
			this.menuItemFile.Text = "文件(&F)";
			// 
			// menuItemOpen
			// 
			this.menuItemOpen.Index = 0;
			this.menuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuItemOpen.Text = "打开";
			this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
			// 
			// menuItemSeparator
			// 
			this.menuItemSeparator.Index = 1;
			this.menuItemSeparator.Text = "-";
			// 
			// menuItemClose
			// 
			this.menuItemClose.Index = 2;
			this.menuItemClose.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.menuItemClose.Text = "退出";
			this.menuItemClose.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItemSet
			// 
			this.menuItemSet.Index = 1;
			this.menuItemSet.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuItemColor,
																						this.menuItemFont});
			this.menuItemSet.Text = "设置(&S)";
			// 
			// menuItemColor
			// 
			this.menuItemColor.Index = 0;
			this.menuItemColor.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuItemBlue,
																						  this.menuItemRed,
																						  this.menuItemWhite});
			this.menuItemColor.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItemColor.Text = "窗体背景(&C)";
			// 
			// menuItemBlue
			// 
			this.menuItemBlue.Index = 0;
			this.menuItemBlue.RadioCheck = true;
			this.menuItemBlue.Text = "蓝色";
			this.menuItemBlue.Click += new System.EventHandler(this.menuItemBlue_Click);
			// 
			// menuItemRed
			// 
			this.menuItemRed.Index = 1;
			this.menuItemRed.RadioCheck = true;
			this.menuItemRed.Text = "红色";
			this.menuItemRed.Click += new System.EventHandler(this.menuItemRed_Click);
			// 
			// menuItemWhite
			// 
			this.menuItemWhite.Index = 2;
			this.menuItemWhite.RadioCheck = true;
			this.menuItemWhite.Text = "白色";
			this.menuItemWhite.Click += new System.EventHandler(this.menuItemWhite_Click);
			// 
			// menuItemFont
			// 
			this.menuItemFont.Index = 1;
			this.menuItemFont.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemSmall,
																						 this.menuItemMedium,
																						 this.menuItemLarge});
			this.menuItemFont.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.menuItemFont.Text = "字体大小(&Z)";
			// 
			// menuItemSmall
			// 
			this.menuItemSmall.Index = 0;
			this.menuItemSmall.Text = "小";
			this.menuItemSmall.Click += new System.EventHandler(this.menuItemSmall_Click);
			// 
			// menuItemMedium
			// 
			this.menuItemMedium.Index = 1;
			this.menuItemMedium.Text = "中";
			this.menuItemMedium.Click += new System.EventHandler(this.menuItemMedium_Click);
			// 
			// menuItemLarge
			// 
			this.menuItemLarge.Index = 2;
			this.menuItemLarge.Text = "大";
			this.menuItemLarge.Click += new System.EventHandler(this.menuItemLarge_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.ContextMenu = this.contextMenu1;
			this.richTextBox1.Location = new System.Drawing.Point(56, 40);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(312, 56);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "请右击显示弹出菜单";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "文本文件 (*.txt)|*.txt";
			this.openFileDialog1.InitialDirectory = "C:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(416, 153);
			this.ContextMenu = this.contextMenu2;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "菜单设计";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			//退出程序
			this.Close();
		}

		private void menuItemBlue_Click(object sender, System.EventArgs e)
		{
			//设置背景颜色
			this.BackColor=Color.Blue;
		    //改变菜单项的Checked属性
			menuItemBlue.Checked=true;
			menuItemRed.Checked=false;
			menuItemWhite.Checked=false;
		}

		private void menuItemRed_Click(object sender, System.EventArgs e)
		{
			//设置背景颜色
			this.BackColor=Color.Red;
			//改变菜单项的Checked属性
			menuItemBlue.Checked=false;
			menuItemRed.Checked=true;
			menuItemWhite.Checked=false;
		}

		private void menuItemWhite_Click(object sender, System.EventArgs e)
		{
			//设置背景颜色
			this.BackColor=Color.White;
			//改变菜单项的Checked属性
			menuItemBlue.Checked=false;
			menuItemRed.Checked=false;
			menuItemWhite.Checked=true;
		}

		private void menuItemSmall_Click(object sender, System.EventArgs e)
		{
			//改变菜单项的Checked属性
			menuItemSmall.Checked=true;
			menuItemMedium.Checked=false;
			menuItemLarge.Checked=false;
			//设置字体大小
			this.richTextBox1.Font=new Font("小字体",FontSizes.Small);
		}

		private void menuItemMedium_Click(object sender, System.EventArgs e)
		{
			//改变菜单项的Checked属性
			menuItemSmall.Checked=false;
			menuItemMedium.Checked=true;
			menuItemLarge.Checked=false;
            //设置字体大小
			this.richTextBox1.Font=new Font("中字体",FontSizes.Medium);
		}

		private void menuItemLarge_Click(object sender, System.EventArgs e)
		{
			//改变菜单项的Checked属性
			menuItemSmall.Checked=false;
			menuItemMedium.Checked=false;
			menuItemLarge.Checked=true;
			//设置字体大小
			this.richTextBox1.Font=new Font("大字体",FontSizes.Large);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{ 
            //为contextMenu1复制菜单项
			this.contextMenu1.MenuItems.Add(this.menuItemFont.CloneMenu());
			//为contextMenu2复制菜单项
		    this.contextMenu2.MenuItems.Add(this.menuItemColor.CloneMenu());
		}

		private void menuItemOpen_Click(object sender, System.EventArgs e)
		{
			//显示openFileDialog1对话框，选定一个文本文件
			this.openFileDialog1.ShowDialog();
		}

	
	

	
	}
}
