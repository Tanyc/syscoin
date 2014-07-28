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
	/// Form1 ��ժҪ˵����
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
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.label1.Text = "��ѡ��XML�ļ�";
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
			this.button1.Text = "��� ...";
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
			this.button2.Text = "��ȡ";
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
			this.Text = "��ȡXML�ĵ�";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofDialog=new OpenFileDialog();
			//���ù�����
			ofDialog.Filter="XML�ļ�(*.xml)|*.xml|�����ļ�(*.*)|*.*";
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
			//��ȡ�ļ���
			this.textBox1.Text=ofDialog.FileName;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//��ȡҪ��ȡ��XML�ļ���
			string fileName=this.textBox1.Text.Trim();
			if (fileName!="")
			{
				//����XmlTextReader��ȡ��
				XmlTextReader reader=new XmlTextReader(fileName);
				this.richTextBox1.Text="";
				try
				{
				
					//��ȡ�ĵ��е����нڵ�
					while (reader.Read())
					{
						//���ݽڵ�����Ͷ�ȡ�������Ӧ������
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
					    //��ʾ����
						MessageBox.Show("��������"+excep.Message,"����",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
			}
			else
			{
			//û��ѡ���ļ�
			MessageBox.Show("û��ѡ��XML�ļ�","����",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
	}
}
