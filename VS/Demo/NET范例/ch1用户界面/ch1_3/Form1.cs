using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_3
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.Button button1;
		private Form2 form2Example;
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
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(80, 168);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(144, 32);
			this.button3.TabIndex = 5;
			this.button3.Text = "���ش���";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(80, 104);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 32);
			this.button2.TabIndex = 4;
			this.button2.Text = "��ʾ����";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "�½�����";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button3,
																		  this.button2,
																		  this.button1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "������";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void button3_Click(object sender, System.EventArgs e)
		{
			//ʹ��������
			form2Example.Visible=false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			form2Example= new Form2();
			//����һ�������Button2,Button3�Ϳ���ʹ���ˣ���Button1����ʹ��
			button1.Enabled=false;
			button2.Enabled=true;
			button3.Enabled=true;
			form2Example.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//ʹ����ɼ�
			form2Example.Visible=true;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//���ô����λ�úʹ�С
			Rectangle pos= new Rectangle(250,250,300,300);
			this.Bounds=pos;
		}
	}
}
