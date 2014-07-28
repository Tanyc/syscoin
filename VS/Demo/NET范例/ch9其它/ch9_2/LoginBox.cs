using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ch9_2
{
	public enum LoginButtonText
	{
		ȷ��,��¼,����,OK
	};
	/// <summary>
	/// UserControl1 ��ժҪ˵����
	/// </summary>
	public class loginBox : System.Windows.Forms.UserControl
	{
		private  System.Windows.Forms.TextBox textBoxUser;
		private  System.Windows.Forms.TextBox textBoxPwd;
		private System.Windows.Forms.Button buttonLogin;
		
		[Browsable(true)]
		protected  LoginButtonText loginText;
        public  LoginButtonText  LoginText
		{
			get
			{
			return loginText;
			}
			set
			{
			loginText=value;
		    this.buttonLogin.Text=loginText.ToString();
			}
		}
       
		[Browsable(true)] 
		protected  string  username;
		public  string  Username
		{
			get
			{
				return username;
			}
			set
			{
				username=value;
			    this.textBoxUser.Text=username;
			}
		}
      
        [Browsable(true)] 
		protected  string  password;
		public  string  Password
		{
			get
			{
				return password;
			}
			set
			{
				password=value;
				this.textBoxPwd.Text=password;
			}
		}
    	[Browsable(true)]
		public event System.EventHandler LoginButtonClick;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public loginBox()
		{
			// �õ����� Windows.Forms ���������������ġ�
			InitializeComponent();
			username="�������û���";
			password="********";

			// TODO: �� InitializeComponent ���ú�����κγ�ʼ��

		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭�� 
		/// �޸Ĵ˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.textBoxPwd = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxUser
			// 
			this.textBoxUser.Location = new System.Drawing.Point(8, 16);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(80, 21);
			this.textBoxUser.TabIndex = 0;
			this.textBoxUser.Text = "�û���";
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(8, 96);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(80, 23);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "ȷ��";
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// textBoxPwd
			// 
			this.textBoxPwd.Location = new System.Drawing.Point(8, 56);
			this.textBoxPwd.Name = "textBoxPwd";
			this.textBoxPwd.PasswordChar = '*';
			this.textBoxPwd.Size = new System.Drawing.Size(80, 21);
			this.textBoxPwd.TabIndex = 1;
			this.textBoxPwd.Text = "****";
			// 
			// loginBox
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBoxPwd,
																		  this.buttonLogin,
																		  this.textBoxUser});
			this.Name = "loginBox";
			this.Size = new System.Drawing.Size(96, 136);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonLogin_Click(object sender, System.EventArgs e)
		{
			if (this.LoginButtonClick!=null)
			{
			LoginButtonClick(this,e);
			}
		}
	}
}
