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
	/// Form1 的摘要说明。
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
			this.groupBox1.Text = "文件加密";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "选择加密文件";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(280, 172);
			this.button2.Name = "button2";
			this.button2.TabIndex = 6;
			this.button2.Text = "确定";
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
			this.label2.Text = "确认密码";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "设定密码";
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
			this.button1.Text = "浏览...";
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
			this.button3.Text = "开始加密";
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
			this.groupBox2.Text = "文件解密";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(280, 32);
			this.button4.Name = "button4";
			this.button4.TabIndex = 9;
			this.button4.Text = "浏览...";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "选择解密文件";
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
			this.button5.Text = "开始解密";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "输出文件名";
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
			this.button6.Text = "浏览...";
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
			this.label6.Text = "输入密码";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(280, 68);
			this.button7.Name = "button7";
			this.button7.TabIndex = 17;
			this.button7.Text = "浏览...";
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
			this.label7.Text = "输出文件名";
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(24, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(168, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "请注意：密码必须大于6位";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(440, 469);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "文件的加密解密";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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

		private void button3_Click(object sender, System.EventArgs e)
		{
			//获得待加密文件名
			string inName=this.textBox1.Text;
			//获得保存文件名
			string outName=this.textBox2.Text;

            //设定初始向量
			byte[]  desIV={0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08};
			byte[]  desKey={};
            //根据密码算出密钥
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
		
			//创建文件流分别指向输入和输出文件
			FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
			FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
			fout.SetLength(0);
		    
			//每次的中间流.
			byte[] bin = new byte[100]; 
			//代表已经加密的流的大小
			int complete=0;
			//代表要加密文件总的大小
			long totlen = fin.Length; 
			//每次写入的大小
			int len;   
		
			//创建DES对象
			DES des = new DESCryptoServiceProvider();     
			//创建加密流	
			CryptoStream encStream = new CryptoStream(fout, des.CreateEncryptor(desKey, desIV), CryptoStreamMode.Write);
		            
			//从输入文件中读取流，然后加密到输出文件中
			while(complete < totlen)
			{
				len = fin.Read(bin, 0, 100);
				encStream.Write(bin, 0, len);
				complete = complete + len;
			}
		    
			//关闭流
			encStream.Close();  
			fout.Close();
			fin.Close();                   

	    	MessageBox.Show("文件加密已经完成","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
	    }

		private void button5_Click(object sender, System.EventArgs e)
		{
			//获得要解密的文件名
			string inName=this.textBox5.Text;
			//获得要保存的文件名
			string outName=this.textBox6.Text;

			//设定初始向量
			byte[]  desIV={0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08};
			byte[]  desKey={};
			//根据密码算出密钥
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

				//创建文件流分别指向输入和输出文件
				FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
				FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
				fout.SetLength(0);
       
				//每次的中间流.
				byte[] bin = new byte[100]; 
				//代表已经解密的流的大小
				int complete=0;
				//代表要解密文件总的大小
				long totlen = fin.Length; 
				//每次写入的大小
				int len;                   
                
				//创建DES对象
				DES des = new DESCryptoServiceProvider();     
				//创建解密流
				CryptoStream decStream = new  CryptoStream(fout, des.CreateDecryptor(desKey,desIV), CryptoStreamMode.Write);
                
 
				//从输入文件中读取流，然后解密到输出文件中
				while(complete < totlen)
				{
					len = fin.Read(bin, 0, 100);
					decStream.Write(bin, 0, len);
					complete=complete+len;
				}
 
				  //关闭流		
				decStream.Close();  
				fout.Close();
				fin.Close();     

				MessageBox.Show("文件解密已经完成","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			catch (Exception error)
			{
            //密码不正确的警告
			MessageBox.Show("操作有误: "+error.Message,"警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
			
			}
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofDialog=new OpenFileDialog();
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
				//将待加密文件的路径写到文本框
				this.textBox1.Text=ofDialog.FileName;
			};
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
		
		
			SaveFileDialog sfDialog=new SaveFileDialog();
			//设置过滤器
			sfDialog.Filter="My encrypt file(*.mef)|*.mef|All files(*.*)|*.*";
			if (sfDialog.ShowDialog()==DialogResult.OK)
			{
			   //将加密文件的保存路径写到文本框
				this.textBox2.Text=sfDialog.FileName;
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofDialog=new OpenFileDialog();
			//设置过滤器
			ofDialog.Filter="My encrypt file(*.mef)|*.mef|All files(*.*)|*.*";
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
				//将待解密文件的路径写到文本框
				this.textBox5.Text=ofDialog.FileName;
			};
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfDialog=new SaveFileDialog();
			if (sfDialog.ShowDialog()==DialogResult.OK)
			{
				//将解密文件的保存路径写到文本框
				this.textBox6.Text=sfDialog.FileName;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//确认密码是否输入正确
			if (this.textBox3.Text.Length<6 | this.textBox3.Text!=this.textBox4.Text)
			{
				MessageBox.Show("请选择正确的密码","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				//确认加密文件名和保存文件名是否正确
				if (this.textBox1.Text=="")
				{
					MessageBox.Show("请选择加密文件","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else
				{
					if (this.textBox2.Text=="")
					{
						MessageBox.Show("请输入保存文件名","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}			
					else
					{
					//现在可以进行加密了
					this.button3.Enabled=true;
					}
				}			
			}
		}
	}
}
