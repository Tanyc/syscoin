using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.IO;
namespace ch3_11
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;

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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label8,
																					this.button6,
																					this.textBox2,
																					this.label5,
																					this.button3,
																					this.label3,
																					this.button2,
																					this.textBox4,
																					this.label2,
																					this.label1,
																					this.textBox3,
																					this.button1,
																					this.textBox1});
			this.groupBox1.Location = new System.Drawing.Point(24, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(392, 248);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "�ļ�����";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "ѡ������ļ�";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(280, 172);
			this.button2.Name = "button2";
			this.button2.TabIndex = 6;
			this.button2.Text = "ȷ��";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(144, 172);
			this.textBox4.Name = "textBox4";
			this.textBox4.PasswordChar = '*';
			this.textBox4.Size = new System.Drawing.Size(120, 21);
			this.textBox4.TabIndex = 5;
			this.textBox4.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "ȷ������";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "�趨����";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(144, 128);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(120, 21);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 32);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "���...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(144, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(24, 216);
			this.button3.Name = "button3";
			this.button3.TabIndex = 8;
			this.button3.Text = "��ʼ����";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button7,
																					this.textBox6,
																					this.label7,
																					this.label6,
																					this.textBox7,
																					this.button5,
																					this.label4,
																					this.button4,
																					this.textBox5});
			this.groupBox2.Location = new System.Drawing.Point(24, 288);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(392, 160);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "�ļ�����";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(280, 32);
			this.button4.Name = "button4";
			this.button4.TabIndex = 9;
			this.button4.Text = "���...";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "ѡ������ļ�";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(144, 32);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(120, 21);
			this.textBox5.TabIndex = 8;
			this.textBox5.Text = "";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(280, 110);
			this.button5.Name = "button5";
			this.button5.TabIndex = 12;
			this.button5.Text = "��ʼ����";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "����ļ���";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(144, 72);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 21);
			this.textBox2.TabIndex = 10;
			this.textBox2.Text = "";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(280, 72);
			this.button6.Name = "button6";
			this.button6.TabIndex = 11;
			this.button6.Text = "���...";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(144, 112);
			this.textBox7.Name = "textBox7";
			this.textBox7.PasswordChar = '*';
			this.textBox7.Size = new System.Drawing.Size(120, 21);
			this.textBox7.TabIndex = 13;
			this.textBox7.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(32, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "��������";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(280, 68);
			this.button7.Name = "button7";
			this.button7.TabIndex = 17;
			this.button7.Text = "���...";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(144, 72);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(120, 21);
			this.textBox6.TabIndex = 16;
			this.textBox6.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(32, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "����ļ���";
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(24, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(168, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "��ע�⣺����������6λ";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(440, 469);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "�ļ��ļ��ܽ���";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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
			//��ô������ļ���
			string inName=this.textBox1.Text;
			//��ñ����ļ���
			string outName=this.textBox2.Text;

            //�趨��ʼ����
			byte[]  desIV={0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08};
			byte[]  desKey={};
            //�������������Կ
			string keyString=this.textBox3.Text;
			if (keyString.Length>=8)
			{
				desKey=new byte[]{(byte)keyString[0],(byte)keyString[1],(byte)keyString[2],
				(byte)keyString[3],(byte)keyString[4],(byte)keyString[5],
				(byte)keyString[6],(byte)keyString[7]};
			}
				    
			if (keyString.Length==6)
			{
				desKey=new byte[]{(byte)keyString[0],(byte)keyString[1],(byte)keyString[2],
								  (byte)keyString[3],(byte)keyString[4],(byte)keyString[5],
								  0x07,0x08};
			}
			if (keyString.Length==7)
			{
				desKey=new byte[]{(byte)keyString[0],(byte)keyString[1],(byte)keyString[2],
								  (byte)keyString[3],(byte)keyString[4],(byte)keyString[5],
								  (byte)keyString[6],0x07};
			
			}
		
			//�����ļ����ֱ�ָ�����������ļ�
			FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
			FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
			fout.SetLength(0);
		    
			//ÿ�ε��м���.
			byte[] bin = new byte[100]; 
			//�����Ѿ����ܵ����Ĵ�С
			int complete=0;
			//����Ҫ�����ļ��ܵĴ�С
			long totlen = fin.Length; 
			//ÿ��д��Ĵ�С
			int len;   
		
			//����DES����
			DES des = new DESCryptoServiceProvider();     
			//����������	
			CryptoStream encStream = new CryptoStream(fout, des.CreateEncryptor(desKey, desIV), CryptoStreamMode.Write);
		            
			//�������ļ��ж�ȡ����Ȼ����ܵ�����ļ���
			while(complete < totlen)
			{
				len = fin.Read(bin, 0, 100);
				encStream.Write(bin, 0, len);
				complete = complete + len;
			}
		    
			//�ر���
			encStream.Close();  
			fout.Close();
			fin.Close();                   

	    	MessageBox.Show("�ļ������Ѿ����","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
	    }

		private void button5_Click(object sender, System.EventArgs e)
		{
			//���Ҫ���ܵ��ļ���
			string inName=this.textBox5.Text;
			//���Ҫ������ļ���
			string outName=this.textBox6.Text;

			//�趨��ʼ����
			byte[]  desIV={0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08};
			byte[]  desKey={};
			//�������������Կ
			string keyString=this.textBox7.Text;
			if (keyString.Length>=8)
			{
				desKey=new byte[]{(byte)keyString[0],(byte)keyString[1],(byte)keyString[2],
									 (byte)keyString[3],(byte)keyString[4],(byte)keyString[5],
									 (byte)keyString[6],(byte)keyString[7]};
			}
				    
			if (keyString.Length==6)
			{
				desKey=new byte[]{(byte)keyString[0],(byte)keyString[1],(byte)keyString[2],
									 (byte)keyString[3],(byte)keyString[4],(byte)keyString[5],
									 0x07,0x08};
			}
			if (keyString.Length==7)
			{
				desKey=new byte[]{(byte)keyString[0],(byte)keyString[1],(byte)keyString[2],
									 (byte)keyString[3],(byte)keyString[4],(byte)keyString[5],
									 (byte)keyString[6],0x07};
			
			}

			try
			{

				//�����ļ����ֱ�ָ�����������ļ�
				FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
				FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
				fout.SetLength(0);
       
				//ÿ�ε��м���.
				byte[] bin = new byte[100]; 
				//�����Ѿ����ܵ����Ĵ�С
				int complete=0;
				//����Ҫ�����ļ��ܵĴ�С
				long totlen = fin.Length; 
				//ÿ��д��Ĵ�С
				int len;                   
                
				//����DES����
				DES des = new DESCryptoServiceProvider();     
				//����������
				CryptoStream decStream = new  CryptoStream(fout, des.CreateDecryptor(desKey,desIV), CryptoStreamMode.Write);
                
 
				//�������ļ��ж�ȡ����Ȼ����ܵ�����ļ���
				while(complete < totlen)
				{
					len = fin.Read(bin, 0, 100);
					decStream.Write(bin, 0, len);
					complete=complete+len;
				}
 
				  //�ر���		
				decStream.Close();  
				fout.Close();
				fin.Close();     

				MessageBox.Show("�ļ������Ѿ����","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			catch (Exception error)
			{
            //���벻��ȷ�ľ���
			MessageBox.Show("��������: "+error.Message,"����",MessageBoxButtons.OK,MessageBoxIcon.Error);
			
			}
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofDialog=new OpenFileDialog();
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
				//���������ļ���·��д���ı���
				this.textBox1.Text=ofDialog.FileName;
			};
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
		
		
			SaveFileDialog sfDialog=new SaveFileDialog();
			//���ù�����
			sfDialog.Filter="My encrypt file(*.mef)|*.mef|All files(*.*)|*.*";
			if (sfDialog.ShowDialog()==DialogResult.OK)
			{
			   //�������ļ��ı���·��д���ı���
				this.textBox2.Text=sfDialog.FileName;
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofDialog=new OpenFileDialog();
			//���ù�����
			ofDialog.Filter="My encrypt file(*.mef)|*.mef|All files(*.*)|*.*";
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
				//���������ļ���·��д���ı���
				this.textBox5.Text=ofDialog.FileName;
			};
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfDialog=new SaveFileDialog();
			if (sfDialog.ShowDialog()==DialogResult.OK)
			{
				//�������ļ��ı���·��д���ı���
				this.textBox6.Text=sfDialog.FileName;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//ȷ�������Ƿ�������ȷ
			if (this.textBox3.Text.Length<6 | this.textBox3.Text!=this.textBox4.Text)
			{
				MessageBox.Show("��ѡ����ȷ������","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				//ȷ�ϼ����ļ����ͱ����ļ����Ƿ���ȷ
				if (this.textBox1.Text=="")
				{
					MessageBox.Show("��ѡ������ļ�","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else
				{
					if (this.textBox2.Text=="")
					{
						MessageBox.Show("�����뱣���ļ���","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}			
					else
					{
					//���ڿ��Խ��м�����
					this.button3.Enabled=true;
					}
				}			
			}
		}
	}
}
