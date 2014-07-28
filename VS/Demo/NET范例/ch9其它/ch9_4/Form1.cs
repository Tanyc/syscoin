using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
namespace ch9_4
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "请选定XML文件";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(232, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "浏览 ...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.richTextBox1.Location = new System.Drawing.Point(0, 85);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(408, 312);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(328, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(64, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "读取";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textBox1,
																					this.button1,
																					this.label1,
																					this.button2});
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(408, 80);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(408, 397);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.richTextBox1});
			this.Name = "Form1";
			this.Text = "读取XML文档";
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
			OpenFileDialog ofDialog=new OpenFileDialog();
			//设置过滤器
			ofDialog.Filter="XML文件(*.xml)|*.xml|所有文件(*.*)|*.*";
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
			//获取文件名
			this.textBox1.Text=ofDialog.FileName;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//获取要读取的XML文件名
			string fileName=this.textBox1.Text.Trim();
			if (fileName!="")
			{
				//创建XmlTextReader读取器
				XmlTextReader reader=new XmlTextReader(fileName);
				this.richTextBox1.Text="";
				try
				{
				
					//读取文档中的所有节点
					while (reader.Read())
					{
						//根据节点的类型读取并输出相应的内容
						switch (reader.NodeType)
						{
							case XmlNodeType.XmlDeclaration:
								this.richTextBox1.Text+="<?" + reader.Name + " " + reader.Value + "?>";
								break;
							case XmlNodeType.Element:
								this.richTextBox1.Text+="<" + reader.Name;
								while (reader.MoveToNextAttribute())
									this.richTextBox1.Text+=" " + reader.Name + "=\"" + reader.Value + "\"";
								this.richTextBox1.Text+=">";
								break;
							case XmlNodeType.Text:
								this.richTextBox1.Text+=reader.Value;
								break;
							case XmlNodeType.CDATA:
								this.richTextBox1.Text+=reader.Value;
								break;
							case XmlNodeType.ProcessingInstruction:
								this.richTextBox1.Text+="<?" + reader.Name + " " + reader.Value + "?>";
								break;
							case XmlNodeType.Comment:
								this.richTextBox1.Text+="<!--" + reader.Value + "-->";
								break;
							case XmlNodeType.Document:
								this.richTextBox1.Text+="<?xml version='1.0'?>";
								break;
							case XmlNodeType.Whitespace:
								this.richTextBox1.Text+=reader.Value;
								break;
							case XmlNodeType.SignificantWhitespace:
								this.richTextBox1.Text+=reader.Value;
								break;
							case XmlNodeType.EndElement:
								this.richTextBox1.Text+="</" + reader.Name + ">";
								break;
						}
					}
				}
				catch(Exception excep)
				{
					    //显示错误
						MessageBox.Show("发生错误："+excep.Message,"警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
			}
			else
			{
			//没有选择文件
			MessageBox.Show("没有选择XML文件","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
	}
}
