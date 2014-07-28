using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch3_8
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.ComponentModel.IContainer components;
        
		//代表最近10个在剪贴板上保存的数据
		private string[] clipboardText=new string[]{"","","","","","","","","",""};

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
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(416, 37);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 37);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(416, 304);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 15);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.DropDownMenu = this.contextMenu1;
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Text = "剪切";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton2.Text = "复制";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.DropDownMenu = this.contextMenu1;
			this.toolBarButton3.ImageIndex = 2;
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButton3.Text = "粘贴";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(416, 341);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1,
																		  this.toolBar1});
			this.Name = "Form1";
			this.Text = "剪贴板循环";
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

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//如果是剪切或者复制按钮则进入
			if (e.Button==this.toolBarButton1 | e.Button==this.toolBarButton2)
			{   
				//获得要加入剪贴板的字符串
			    string s=this.richTextBox1.SelectedText;

				//实现剪切按钮的功能
				if (e.Button==this.toolBarButton1)
				{
				//剪切需要把字符串消除
				this.richTextBox1.SelectedText="";
				
				}
			
			    //实现拷贝和剪切共同的功能

				//将字符串放到剪贴板上
				Clipboard.SetDataObject(s);

				//下面为粘贴按钮动态添加菜单
				if (this.contextMenu1!=null )
				{
					//看看菜单的数目，如果少于10则添加
					int i=this.contextMenu1.MenuItems.Count;
					if (i<10)
					{
						//设置菜单项的Text属性，多出15个字符的部分不显示
						MenuItem newItem=new MenuItem("文本："+s);
						if (s.Length>15)
						{
							newItem.Text="文本："+s.Substring(0,15)+"...";
						} 
						//为菜单项的click按钮添加事件处理代理
						newItem.Click+=new EventHandler(menuItemClick);
                        //动态添加菜单项
						this.contextMenu1.MenuItems.Add(newItem);

				        //剪贴板内容字符串数组设置
						this.clipboardText[i]=s;
					}

					//如果大于10，则清空第一项菜单，其余的向后递推
					else
					{
						string temp=this.clipboardText[0];
						//设置菜单项的Text属性，多出15个字符的部分不显示
                        MenuItem newItem=new MenuItem("文本："+s);
						if (s.Length>15)
						{
							 newItem.Text="文本："+s.Substring(0,15)+"...";
						} 
                        newItem.Click+=new EventHandler(menuItemClick);

                        //递推原来菜单项0-9项成为新菜单项的2-10项
						this.clipboardText[0]=s;
						for (int j=0;j<9;j++)
						{
						string temp1=this.clipboardText[j+1];
						this.clipboardText[j+1]=temp;
						this.contextMenu1.MenuItems[j+1].Text="文本："+temp;
						temp=temp1;
						}
						
					}
				}
				else
				{
					//初始化第一个菜单项
					MenuItem newItem=new MenuItem("文本："+s);
					if (s.Length>15)
					{
						newItem.Text="文本："+s.Substring(0,15)+"...";
					} 
					newItem.Click+=new EventHandler(menuItemClick);
					this.contextMenu1.MenuItems.Add(newItem);
					this.contextMenu1.MenuItems[0].Text="文本："+s;
					this.clipboardText[0]=s;
				}

			}
			//实现粘贴按钮的功能
			if (e.Button==this.toolBarButton3)
			{
				try
				{
					IDataObject d = Clipboard.GetDataObject ( ) ;
					//判断剪切板中数据是不是文本
					if ( d.GetDataPresent ( DataFormats.UnicodeText ) ) 
					{
						//将文本对象粘贴到文本框里面
						this.richTextBox1.Paste();
						
					}
					else
					{
						//如果剪贴板上没有文本，则发出提醒
						MessageBox.Show("没有可粘贴的文本","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					}
				}
				catch(Exception error)
				{
					//读取剪贴板出错处理		
					MessageBox.Show("错误信息是： "+error.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);

				}
			}
		}
	
		//菜单项事件处理
		private void menuItemClick (object sender, System.EventArgs e)
		{
	    //获取发出信息的菜单项
		MenuItem mItem=(MenuItem)sender;
		//获得菜单项索引
		int i =mItem.Index;
		//放到剪贴板
		Clipboard.SetDataObject(this.clipboardText[i]);
		//拷贝它到richTextBox上
		this.richTextBox1.Paste();	
		}
	}

}
