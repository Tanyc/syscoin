using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Microsoft.Win32;

namespace ch4_4
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button3;
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
            InitialComboBox();
			InitialForm1();
				//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}
         
		private void InitialComboBox()
		{
			//��FormBorderStyleö��ֵ���뵽comboBox��ȥ
			for (int i=0;i<7;i++)
			{
				this.comboBox1.Items.Add(((FormBorderStyle)i).ToString());
			}
			this.comboBox1.SelectedIndex=1;
		}

		private void InitialForm1()
		{
			//��ȡ�����½�Form1����
			RegistryKey  hLocalMachine=Registry.LocalMachine;
			RegistryKey  software=hLocalMachine.OpenSubKey("SOFTWARE",true);
			RegistryKey  newNode=software.CreateSubKey("Form1");
			//�����������������Ӽ���Ŀ��Ϊ0�����ȡ�Ӽ�
			if (newNode.SubKeyCount!=0)
			{
				RegistryKey  formColor=newNode.CreateSubKey("formColor");
				//��ȡcolor��ֵ
				string color=formColor.GetValue("color").ToString();
				RegistryKey  borderStyle=newNode.CreateSubKey("borderStyle");
				//��ȡborderStyle��ֵ
				string style=borderStyle.GetValue("borderStyle").ToString();

				//����color��ֵ�趨radioButton��checked����
				if (color=="red") 
				{
					this.BackColor=Color.Red;
					this.radioButton1.Checked=true;
				}
				if (color=="yellow") 
				{
					this.BackColor=Color.Yellow;
					this.radioButton2.Checked=true;
				}
				//��stringת��Ϊint
				int i=Int32.Parse(style);
				//����color�ļ�ֵ�趨FormBorderStyle����
				FormBorderStyle fStyle=(FormBorderStyle)i;
				this.FormBorderStyle=fStyle;
				this.comboBox1.SelectedIndex=i;			    
			}
			//�����������������Ӽ���ĿΪ0�������Ĭ�ϳ�ʼ��
			else
			{
			this.radioButton3.Checked=true;
			this.comboBox1.SelectedIndex=1;
			}
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.comboBox1,
																					this.label2,
																					this.radioButton3,
																					this.radioButton2,
																					this.radioButton1,
																					this.label1});
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "����";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(136, 72);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(120, 20);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "����߿���ʽ";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(216, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(32, 18);
			this.radioButton3.TabIndex = 3;
			this.radioButton3.Text = "��";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(168, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(32, 18);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "��";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(112, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(48, 18);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.Text = "��";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "���屳����ɫ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "д��ע���";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 160);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "�ָ�ע���";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(200, 160);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "�˳�";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 199);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "ע����Ϣ�Ĵ�����ɾ��";
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
			string  selectColor="none";
			if (this.radioButton1.Checked==true){selectColor="red";};
			if (this.radioButton2.Checked==true){selectColor="yellow";};
        	int fStyle=this.comboBox1.SelectedIndex;
		             
			//��û򴴽�����Form1��Ϣ�Ľڵ�
			RegistryKey  hLocalMachine=Registry.LocalMachine;
			RegistryKey  software=hLocalMachine.OpenSubKey("SOFTWARE",true);
			RegistryKey  newNode=software.CreateSubKey("Form1");
		
			//����һ���Ӽ�formColor
			RegistryKey  formColor=newNode.CreateSubKey("formColor");
			//����һ����color���ļ�ֵ
			formColor.SetValue("color",selectColor);
        
			//����һ���Ӽ�borderStyle
			RegistryKey  borderStyle=newNode.CreateSubKey("borderStyle");
			//����һ����borderStyle�ļ�ֵ
			borderStyle.SetValue("borderStyle",fStyle);

			MessageBox.Show("�ѳɹ�д��ע���","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show("��ȷ��Ҫɾ��д��ļ�ֵ��","��ʾ",
				MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
			{
				RegistryKey  hLocalMachine=Registry.LocalMachine;
				RegistryKey  software=hLocalMachine.OpenSubKey("SOFTWARE",true);
				RegistryKey  newNode=software.CreateSubKey("Form1");
				//ɾ��������κ��Ӽ�����
				software.DeleteSubKeyTree("Form1");
                MessageBox.Show("�Ѿ��ɹ�ɾ��д��ļ�ֵ","��ʾ",
				MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
			//�����κδ���
			}
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			//��ֻ֤��һ����ѡť��ѡ��
			if (this.radioButton1.Checked==true)
			{
			this.BackColor=Color.Red;
			this.radioButton2.Checked=false;
			this.radioButton3.Checked=false;
			}
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			//��ֻ֤��һ����ѡť��ѡ��
			if (this.radioButton2.Checked==true)
			{
				this.BackColor=Color.Yellow;
				this.radioButton1.Checked=false;
				this.radioButton3.Checked=false;
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			//��ֻ֤��һ����ѡť��ѡ��
			if (this.radioButton3.Checked==true)
			{
				this.BackColor=Color.Empty;
				this.radioButton1.Checked=false;
				this.radioButton2.Checked=false;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//�ı䴰��߿���ʽ
			int i=this.comboBox1.SelectedIndex;
			FormBorderStyle fStyle=(FormBorderStyle)i;
			this.FormBorderStyle=fStyle;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//�˳�����
			this.Close();
			Application.Exit();
		}
	}
}
