using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ch8_3.localhost;
namespace ch8_3
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
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
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 48);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 96);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "密码";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(160, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(160, 96);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(184, 152);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 213);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.textBox2,
																		  this.textBox1,
																		  this.label2,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "使用SOAP标头的用户验证";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		//获取用户名和密码
		string userName=this.textBox1.Text;
		string passWord=this.textBox2.Text;
		//创建一个验证类的对象
		Authentication valid=new Authentication();
		valid.Username=userName;
		valid.Password=passWord;
		//新建一个Web服务实例
		Service1 validService=new Service1();   
		//设置Web服务验证类的值
        validService.AuthenticationValue=valid;
		//调用Web 服务方法
		string result=validService.ValidateUser();
		//显示结果
	    MessageBox.Show(result,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}
