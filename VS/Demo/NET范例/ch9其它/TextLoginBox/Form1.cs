using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TextLoginBox
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private ch9_2.loginBox loginBox1;
		private System.Windows.Forms.Label label1;
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
			this.loginBox1 = new ch9_2.loginBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loginBox1
			// 
			this.loginBox1.Location = new System.Drawing.Point(88, 96);
			this.loginBox1.LoginText = ch9_2.LoginButtonText.��¼;
			this.loginBox1.Name = "loginBox1";
			this.loginBox1.Password = "********";
			this.loginBox1.Size = new System.Drawing.Size(96, 136);
			this.loginBox1.TabIndex = 0;
			this.loginBox1.Username = "�������û���";
			this.loginBox1.LoginButtonClick += new System.EventHandler(this.loginBox1_LoginButtonClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "LoginBox�ؼ�ʾ��";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(280, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.loginBox1});
			this.Name = "Form1";
			this.Text = "LoginBox�ؼ�ʾ��";
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

		private void loginBox1_LoginButtonClick(object sender, System.EventArgs e)
		{
			MessageBox.Show("��ӭ��ķ���!");
		}
	}
}
