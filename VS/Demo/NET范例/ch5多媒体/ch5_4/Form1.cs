using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch5_4
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Diagnostics.EventLog eventLog1;
		private System.Windows.Forms.Button button1;
		private AxRealAudioObjects.AxRealAudio axRealAudio1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.eventLog1 = new System.Diagnostics.EventLog();
			this.button1 = new System.Windows.Forms.Button();
			this.axRealAudio1 = new AxRealAudioObjects.AxRealAudio();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axRealAudio1)).BeginInit();
			this.SuspendLayout();
			// 
			// eventLog1
			// 
			this.eventLog1.SynchronizingObject = this;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(344, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 20);
			this.button1.TabIndex = 1;
			this.button1.Text = "GO";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// axRealAudio1
			// 
			this.axRealAudio1.Enabled = true;
			this.axRealAudio1.Location = new System.Drawing.Point(0, 56);
			this.axRealAudio1.Name = "axRealAudio1";
			this.axRealAudio1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRealAudio1.OcxState")));
			this.axRealAudio1.Size = new System.Drawing.Size(472, 96);
			this.axRealAudio1.TabIndex = 2;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem5});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4});
			this.menuItem1.Text = "��ַ";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "��";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "�˳�";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8});
			this.menuItem5.Text = "����";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Text = "��ͣ";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "ֹͣ";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.Text = "����";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(56, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(264, 20);
			this.comboBox1.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 8);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "λ�ã�";
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(0, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(472, 8);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(472, 153);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.label1,
																		  this.groupBox1,
																		  this.comboBox1,
																		  this.axRealAudio1,
																		  this.button1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "�����̨����";
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axRealAudio1)).EndInit();
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
			//��ò�����ַ
			string url=this.comboBox1.Text;
			this.axRealAudio1.Source=url;
			//����
			this.axRealAudio1.DoPlay();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
		    //�½�һ��Form2����
			Form2 form=new Form2();
			//���Form2����ȷ������
			if (form.ShowDialog()==DialogResult.OK)
			{
				//�����ַ
		     	this.axRealAudio1.Source=form.comboBox1.Text;
				//����
				this.axRealAudio1.DoPlay();
			}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			//�˳�����
			this.Close();
			Application.Exit();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			//��ͣ���� 
			this.axRealAudio1.DoPlayPause();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
		   //ֹͣ����
			this.axRealAudio1.DoPause();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			//�жϲ˵����ѡ��״̬
			if (this.menuItem8.Checked==true)
			{
				//������
				this.axRealAudio1.SetMute(false);
				//��ѡ��
				this.menuItem8.Checked=false;
			}
			else
			{ 
				//����
				this.axRealAudio1.SetMute(true);
				//ѡ��
				this.menuItem8.Checked=true;		  	
			}
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		
		}

		
	}
}
