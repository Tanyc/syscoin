using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_17
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelUser;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.Label labelNote;
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
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.labelNote = new System.Windows.Forms.Label();
			this.labelUser = new System.Windows.Forms.Label();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "���趨��������";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(184, 112);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '*';
			this.textBox1.Size = new System.Drawing.Size(152, 21);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(224, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 24);
			this.button1.TabIndex = 4;
			this.button1.Text = "ȷ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 160);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "��ȷ����������";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(184, 152);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(152, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// label3
			// 
			this.errorProvider1.SetIconAlignment(this.label3, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
			this.label3.Location = new System.Drawing.Point(48, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 23);
			this.label3.TabIndex = 5;
			// 
			// labelNote
			// 
			this.labelNote.Location = new System.Drawing.Point(48, 72);
			this.labelNote.Name = "labelNote";
			this.labelNote.Size = new System.Drawing.Size(296, 23);
			this.labelNote.TabIndex = 6;
			this.labelNote.Text = "��ע�⣺�����λ��Ӧ���ڵ���6λ�Ҳ�����12λ";
			// 
			// labelUser
			// 
			this.labelUser.Location = new System.Drawing.Point(48, 32);
			this.labelUser.Name = "labelUser";
			this.labelUser.TabIndex = 7;
			this.labelUser.Text = "�û���";
			// 
			// textBoxUser
			// 
			this.textBoxUser.Location = new System.Drawing.Point(184, 32);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(152, 21);
			this.textBoxUser.TabIndex = 1;
			this.textBoxUser.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(384, 277);
			this.Controls.Add(this.textBoxUser);
			this.Controls.Add(this.labelUser);
			this.Controls.Add(this.labelNote);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "��������";
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
			if (this.textBoxUser.Text=="")
			{
			//����ָ���ؼ��Ĵ��������ַ�����������ͬ
			this.errorProvider1.SetError(this.textBoxUser,"�������û���");
            this.label3.Text="ע��ʧ��";
			}
			//���ж������ַ����Ƿ���ȣ�Ȼ�����ж����ǵĳ���
			if (this.textBox1.Text!=this.textBox2.Text)
			{
				this.errorProvider1.SetError(this.textBox2,"����ȷ��������������õò�һ��");
				this.label3.Text="ע��ʧ��";
				Reset();
			}
			else
			{
				if (this.textBox1.Text.Length<6)
				{
					this.errorProvider1.SetError(this.textBox2,"�����������λ��̫�٣��������趨");
					this.label3.Text="ע��ʧ��";
					Reset();
				}
				else 
				{
					if (this.textBox1.Text.Length>12)
					{
						this.errorProvider1.SetError(this.textBox2,"�����������λ��̫�����������趨");
						this.label3.Text="ע��ʧ��";
						Reset();
					}
					else 
					{
						//���뽫������ʾ�ַ�����Ϊ�գ�������ִ���֮�󣬼�ʹ�ٳɹ�������ͼ��Ҳȥ����
						this.errorProvider1.SetError(this.textBox2,"");
					    this.label3.Text="��ӭ�� "+this.textBoxUser.Text+"!";
					}
				}
			}

		}

		private void Reset()
		{
		//��������˴��������textBox1��textBox2���ı�
		this.textBox1.Text="";
		this.textBox2.Text="";
		}

	}
}
