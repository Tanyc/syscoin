using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Globalization;
namespace ch9_5
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.ComboBox comboBox1;
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
			this.comboBox1.SelectedIndex=0;

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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 280);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "ȷ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(208, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(208, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(192, 21);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(208, 88);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(192, 21);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(208, 120);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(192, 21);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "CultureInfo ����Ϊ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "��������Ϊ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "������ĸ�� ISO ��������Ϊ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "�������Ĭ������Ϊ";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "�������Ƿ���ù���";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "������Ļ��ҷ���Ϊ";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "�����������Ϊ";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(208, 152);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(192, 21);
			this.textBox5.TabIndex = 12;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(208, 192);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(192, 21);
			this.textBox6.TabIndex = 11;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(208, 224);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(192, 21);
			this.textBox7.TabIndex = 10;
			this.textBox7.Text = "";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "�й�",
														   "����",
														   "Ӣ��",
														   "����",
														   "�����",
														   "����"});
			this.comboBox1.Location = new System.Drawing.Point(112, 280);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 20);
			this.comboBox1.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(32, 284);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "ѡ�����";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(424, 341);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label5,
																		  this.comboBox1,
																		  this.label6,
																		  this.label7,
																		  this.label8,
																		  this.textBox5,
																		  this.textBox6,
																		  this.textBox7,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1,
																		  this.textBox4,
																		  this.textBox3,
																		  this.textBox2,
																		  this.textBox1,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "��ȡ���Һ�������Ϣ";
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
			//���ѡ�����ҵ�����
			string country=this.comboBox1.SelectedItem.ToString();
			//��ʾ������Ϣ
			string culture="";
			//��ʾ������Ϣ
			string region="";
			//���ݹ��������������Ժ�����
			switch (country)
			{
				case "�й�":
					 culture="zh-CN";
					 region="CN";
					 break;
				case "����":
					 culture="en-US";
					 region="US";
					 break;
				case "Ӣ��":
					 culture="en-GB";
					 region="GB";
					 break;
				case "����":
					 culture="fr";
					 region="FR";
					 break;
				case "�����":
					 culture="it";
					 region="IT";
					 break;
				case "����":
					 culture="ko-KR";
					 region="KR";
					 break;
			}
			//����Ϣ��ʾ����
			GetInfo(culture,region);
			
		}
			  
		private void GetInfo(string culture,string region)
		{	
			  //��ȡ��������Ϣ
			  CultureInfo c = new CultureInfo(culture);
			  this.textBox1.Text=c.DisplayName;
			  this.textBox2.Text=c.Parent.DisplayName;
			  this.textBox3.Text=c.ThreeLetterISOLanguageName;
			  this.textBox4.Text=c.Calendar.ToString();
    
			  //��ȡ������Ϣ
			  RegionInfo r = new RegionInfo(region);
			  this.textBox5.Text=r.DisplayName;
			  this.textBox6.Text=r.CurrencySymbol;
			  this.textBox7.Text=r.IsMetric.ToString();

		}

		
	}
}
