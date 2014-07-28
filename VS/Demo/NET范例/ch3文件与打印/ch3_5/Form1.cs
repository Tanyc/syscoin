using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Printing;
using System.IO;

namespace ch3_5
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.ComponentModel.IContainer components;

		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Drawing.Printing.PrintDocument pDoc;
		
        //表示待打印流
		private StreamReader sReader;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

					        
			//初始化打印流
			sReader=new StreamReader("toprint.txt",System.Text.Encoding.Default);
			//读取文本的全部内容给RichTextBox
			this.richTextBox1.Text=sReader.ReadToEnd();

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
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.pDoc = new System.Drawing.Printing.PrintDocument();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(292, 38);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Text = "打印";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 38);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(292, 235);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// pDoc
			// 
			this.pDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDoc_PrintPage);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1,
																		  this.toolBar1});
			this.Name = "Form1";
			this.Text = "文件打印";
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
			if (e.Button==this.toolBarButton1)
			{
				try 
				{
					pDoc.Print();
				} 	
				catch(Exception error) 
				{
					//打印出错处理
					MessageBox.Show("打印文件发生错误：   " + error.Message);
				}
				finally 
				{
					//关闭字符流
					sReader.Close() ;
				}		
			}
		}

		//每个要打印的页所激发的事件
		private void pDoc_PrintPage(object sender, PrintPageEventArgs e) 
		{
			//获得绘制对象
			Graphics g=e.Graphics;
            //一页中的行数
			float linePage = 0 ;
			//待绘文本的纵向坐标
			float yPosition =  0 ;
			//行计数
			int count = 0 ;
			//左边界
			float leftMargin = e.MarginBounds.Left;
			//顶边界
			float topMargin = e.MarginBounds.Top;
			//字符串流
			String line=null;

		
			//根据页面的高度和字体的高度计算
			//一页中可以打印的行数
			linePage = e.MarginBounds.Height  / this.Font.GetHeight(g) ;
            
			//每次从字符串流中读取一行并打印
			while (count < linePage && ((line=sReader.ReadLine()) != null)) 
			{
				//计算这一行的显示位置
				yPosition = topMargin + (count * this.Font.GetHeight(g));
                //绘制文本
				g.DrawString (line, this.Font, Brushes.Black, leftMargin, yPosition, new StringFormat());
                //行数增加
				count++;
			}

			//如果有多行，则另外打印一页
			if (line != null)
				e.HasMorePages = true ;
			else
				e.HasMorePages = false ;
		}

		
		
	}
}
