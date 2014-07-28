using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
//要用到ImageFormat
using System.Drawing.Imaging;

namespace ch2_9
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(1016, 37);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Text = "打开";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Enabled = false;
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton2.Text = "转换";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 15);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// groupBox1
			// 
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1016, 8);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.toolBar1});
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "图片格式转换器";
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
		
		public  void UpdateToolBar()
		{
			//说明是最后一个子窗体了
			if (this.MdiChildren.Length==1)
			{
			this.toolBarButton2.Enabled=false;
			}
		}
		
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//点击的是打开按钮的处理
			if (e.Button==this.toolBarButton1)
			{
				//设置文件类型过滤器 
				this.openFileDialog1.Filter="Image files (JPeg, Gif, Bmp, etc.)|*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png" 
					+ "|JPeg files (*.jpg;*.jpeg)|*.jpg;*.jpeg" 
					+ "|GIF files (*.gif)|*.gif" 
					+ "|BMP files (*.bmp)|*.bmp" 
					+ "|Tiff files (*.tif;*.tiff)|*.tif;*.tiff" 
					+ "|Png files (*.png)|*.png" 
					+ "|All files (*.*)|*.*";
			
				if (this.openFileDialog1.ShowDialog()==DialogResult.OK)
				{
					//获取文件的详细路径
					string sFileName=this.openFileDialog1.FileName;
					//去掉路径获得文件名
					string sShortName=sFileName.Substring(sFileName.LastIndexOf("\\")+1);

					Bitmap bm=new Bitmap(sFileName);

					Form2 fm=new Form2();
					//将文件名数据传给子窗体的pictureBox
					fm.pictureBox1.Image=bm;
					fm.Width=bm.Width;
					fm.Height=bm.Height+20;
					fm.Text=sShortName;
					//定义此窗体的父窗体，从而此窗体成为一个MDI窗体 
					fm.MdiParent=this;
					fm.Show();

					//显示图片之后就可以使用转换按钮了
					this.toolBarButton2.Enabled=true;

				}
			}

			//点击的是转换按钮的处理程序
			if (e.Button==this.toolBarButton2)
			{
				
				Form3 fm3=new Form3();
				if (fm3.ShowDialog()==DialogResult.OK)
				{
					//进行图片转换，获取从fm3中取得的信息，设定文件转换格式
					string  fileFormat=fm3.listView1.SelectedItems[0].Text;
					ImageFormat iFormat=null;
	
					switch  (fileFormat[0].ToString())
					{
						case "B":
							iFormat=ImageFormat.Bmp;
							break;
						case "J":
							iFormat=ImageFormat.Jpeg;
							break;
						case "T":
							iFormat=ImageFormat.Tiff;
							break;
						case "P":
							iFormat=ImageFormat.Png;
							break;
						case  "G":
							iFormat=ImageFormat.Gif;
							break;
					}
					string  filePath=fm3.textBox1.Text;

					//获取当前子窗体的图像对象
					Form2 fm2=(Form2)this.ActiveMdiChild;
					Bitmap bm=(Bitmap)fm2.pictureBox1.Image;
					try
					{
						//将文件格式转化
						bm.Save(filePath,iFormat);
					}
					catch(Exception error)
					{
						MessageBox.Show(" 错误信息是："+error.Message,"警告",
							MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
				}		   
				
		
	            	
			 }
         
		 }//end toolBar1_ButtonClick
		

	}
}
