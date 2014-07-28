using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace ch3_2
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
			this.toolBar1.Size = new System.Drawing.Size(492, 37);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Text = "打开";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 37);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(492, 336);
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
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton2.Text = "保存";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "doc1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(492, 373);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1,
																		  this.toolBar1});
			this.Name = "Form1";
			this.Text = "文本编辑器";
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
				//设置openFileDialog的过滤器
				this.openFileDialog1.Filter="Text file(*.txt)|*.txt|All files(*.*)|*.*";
				//设置文本读取流为空
				StreamReader sReader=null;
				if (this.openFileDialog1.ShowDialog()==DialogResult.OK)
				{
					try
					{
						string fileName=this.openFileDialog1.FileName;
						//使用文本名称构造文本读取流
						sReader=new StreamReader(fileName,System.Text.Encoding.Default);
						//读取文本的全部内容给RichTextBox
					    this.richTextBox1.Text=sReader.ReadToEnd();
					}
					catch(Exception error)
					{
						MessageBox.Show("错误信息是： "+error.Message,"警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
					finally
					{
						//如果流不为空，关闭它
						if (sReader!=null)
						{
						sReader.Close();
						}
					}
				}
			}//end if 

			if (e.Button==this.toolBarButton2)
			{
			    //设置openFileDialog的过滤器
				this.saveFileDialog1.Filter="Text file(*.txt)|*.txt|All files(*.*)|*.*";
               //设置文本写入流为空
				StreamWriter sWriter=null;
				if (this.saveFileDialog1.ShowDialog()==DialogResult.OK)
				{
					try
					{
					    string saveName=this.saveFileDialog1.FileName;
						//使用文本名称构造文本读取流
						sWriter=new StreamWriter(saveName,false,System.Text.Encoding.GetEncoding("GB2312"));
						//sWriter=new StreamWriter(saveName,false,System.Text.Encoding.Default);
						//将richTextBox中的内容写到文件中
						sWriter.Write(this.richTextBox1.Text);
					}
					catch(Exception error)
					{
						MessageBox.Show("错误信息是： "+error.Message,"警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
					finally
					{
						if (sWriter!=null)
						{
							//如果流不为空，关闭它
							sWriter.Close();
						}
					}
					
				}
			}
		}
	}
}
