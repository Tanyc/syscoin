using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Threading;

namespace ch9_6
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;


		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label5;
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
			this.comboBox1.SelectedIndex=1;
			this.comboBox2.SelectedIndex=1;

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
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "�߳�1��ǰ����";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "��ʼ";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(128, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(128, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "�߳�2��ǰ����";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "��",
														   "����",
														   "��"});
			this.comboBox1.Location = new System.Drawing.Point(200, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(72, 20);
			this.comboBox1.TabIndex = 7;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
														   "��",
														   "����",
														   "��"});
			this.comboBox2.Location = new System.Drawing.Point(200, 40);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(72, 20);
			this.comboBox2.TabIndex = 8;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(0, 96);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(288, 312);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "�����ʾ";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 421);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label5,
																		  this.richTextBox1,
																		  this.comboBox2,
																		  this.comboBox1,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.button1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "���̵߳���";
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

		public void HandleThread1()
		{
				for (int i=0;i<10;i++)
				{
					for (int j=1;j<100;j++)
					{
						this.label2.Text=i.ToString();
					}				
					//��richTextBox1�����
					this.richTextBox1.Text+="�����߳�1�����֣�"+i.ToString()+"\n";
				}			
		}

		
		public void HandleThread2()
		{	  
				for (int i=0;i<10;i++)
				{
					for (int j=1;j<100;j++)
					{
						this.label4.Text=i.ToString();
					}	
					//��richTextBox1�����
					this.richTextBox1.Text+="�����߳�2�����֣�"+i.ToString()+"\n";
				}
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
		//�����߳�1���߳�2��ʵ��
		Thread th1=new Thread(new ThreadStart(HandleThread1));
		Thread th2=new Thread(new ThreadStart(HandleThread2));
		this.richTextBox1.Text=""; 
		int i=this.comboBox1.SelectedIndex;
		    //�����߳�1���ȼ�
		 	switch (i.ToString())
			{
				case "0":
					th1.Priority=ThreadPriority.AboveNormal;
					break;
				case "1":
					th1.Priority=ThreadPriority.Normal;
					break;
				case "2":
					th1.Priority=ThreadPriority.BelowNormal;
					break;
			}
		int j=this.comboBox2.SelectedIndex;
			//�����߳�2���ȼ�
			switch (j.ToString())
			{
				case "0":
					th2.Priority=ThreadPriority.AboveNormal;
					break;
				case "1":
					th2.Priority=ThreadPriority.Normal;
					break;
				case "2":
					th2.Priority=ThreadPriority.BelowNormal;
					break;
			}
        //�����߳�
		th1.Start();
		th2.Start();
		}

		
	}
}
