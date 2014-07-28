using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

//using System.Security;
using System.Security.Cryptography;
using System.Text;


namespace ch9_3
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "输入要进行哈希加密的字符串1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 56);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(224, 24);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(176, 96);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "哈希处理";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(24, 152);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(224, 48);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 112);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "哈希加密结果1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(272, 112);
			this.label3.Name = "label3";
			this.label3.TabIndex = 9;
			this.label3.Text = "哈希加密结果2";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(272, 152);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(224, 48);
			this.textBox4.TabIndex = 8;
			this.textBox4.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(424, 96);
			this.button2.Name = "button2";
			this.button2.TabIndex = 7;
			this.button2.Text = "哈希处理";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(272, 56);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(224, 24);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(272, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "输入要进行哈希加密的字符串2";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(24, 224);
			this.button3.Name = "button3";
			this.button3.TabIndex = 11;
			this.button3.Text = "比较哈希值";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(128, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(240, 23);
			this.label5.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(520, 261);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label5,
																		  this.button3,
																		  this.label3,
																		  this.textBox4,
																		  this.button2,
																		  this.textBox3,
																		  this.label4,
																		  this.label2,
																		  this.textBox2,
																		  this.button1,
																		  this.textBox1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "哈希加密";
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
		
		    
	    	string 	s=this.textBox1.Text;
			//将 s转换为字节数组
			Byte[] byteToHash = Encoding.Default.GetBytes(s);	
			//使用直接创建的 MD5 类的实例创建 String 2	的哈希值
			byte[] hashvalue = (new MD5CryptoServiceProvider()).ComputeHash(byteToHash);
            //将byte数组转化为string
			string hashString=BitConverter.ToString(hashvalue);
		    //输出结果
			this.textBox2.Text=hashString;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string 	s=this.textBox3.Text;
     		//将 s转换为字节数组
			byte[] byteToHash = Encoding.Default.GetBytes(s);	
			//使用由加密配置系统返回的 MD5 实例从 S创建哈希值
			byte[] hashvalue = ((HashAlgorithm) CryptoConfig.CreateFromName("MD5")).ComputeHash(byteToHash);
			//将byte数组转化为string
			string hashString=BitConverter.ToString(hashvalue);
            //输出结果
			this.textBox4.Text=hashString;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//将string转化为byte数组
			byte[] hashvalue1=Encoding.Default.GetBytes(this.textBox2.Text);
			byte[] hashvalue2=Encoding.Default.GetBytes(this.textBox4.Text);
			if (hashvalue1.Length!=0 & hashvalue2.Length!=0)
			{
				//哈希值字节逐一比较
				int i=0;
				//判断是否相等的bool值
				bool same=true;
				do
				{
					if(hashvalue1[i]!=hashvalue2[i])
					{
						same=false;
						break;
					}
					i++;
				}
				while(i<hashvalue1.Length);
				//在label1上输出结果
				if(same) 
					this.label5.Text="字符串 1 和字符串 2 的哈希值相同！";
				else
					this.label5.Text="字符串 1 和字符串 2 的哈希值不同！";
			}
		}
	}
}
