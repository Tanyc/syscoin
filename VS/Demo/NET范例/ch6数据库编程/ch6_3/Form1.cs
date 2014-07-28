using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Data.OleDb;

namespace ch6_3
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;

		private BindingManagerBase myBind;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;

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

			DataBinding();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void DataBinding()
		{
	
			//刷新数据集
			this.oleDbDataAdapter1.Fill(this.dataSet1,"information");

			//数据绑定
			this.textBox1.DataBindings.Add("Text",this.dataSet1,"information.姓名");
			this.textBox2.DataBindings.Add("Text",this.dataSet1,"information.年龄");
			this.textBox3.DataBindings.Add("Text",this.dataSet1,"information.电话");
			this.textBox4.DataBindings.Add("Text",this.dataSet1,"information.电子邮件");		

			//构造
			myBind=this.BindingContext[this.dataSet1,"information"];
		
	   
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
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.dataSet1 = new System.Data.DataSet();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=D:\Documents and Settings\administrator.TRINCE-JULIE\My Documents\person.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "information", new System.Data.Common.DataColumnMapping[] {
																																																					   new System.Data.Common.DataColumnMapping("姓名", "姓名"),
																																																					   new System.Data.Common.DataColumnMapping("年龄", "年龄"),
																																																					   new System.Data.Common.DataColumnMapping("电话", "电话"),
																																																					   new System.Data.Common.DataColumnMapping("电子邮件", "电子邮件")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM information WHERE (姓名 = ?) AND (电子邮件 = ? OR ? IS NULL AND 电子邮件 IS NUL" +
				"L) AND (电话 = ? OR ? IS NULL AND 电话 IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_姓名", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "姓名", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电子邮件", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电子邮件", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电子邮件1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电子邮件", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电话", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电话1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO information(电话, 电子邮件, 年龄, 姓名) VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("电话", System.Data.OleDb.OleDbType.VarWChar, 50, "电话"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("电子邮件", System.Data.OleDb.OleDbType.VarWChar, 50, "电子邮件"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("年龄", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "年龄", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("姓名", System.Data.OleDb.OleDbType.VarWChar, 50, "姓名"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT 电话, 电子邮件, 年龄, 姓名 FROM information";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE information SET 电话 = ?, 电子邮件 = ?, 年龄 = ?, 姓名 = ? WHERE (姓名 = ?) AND (电子邮件 " +
				"= ? OR ? IS NULL AND 电子邮件 IS NULL) AND (电话 = ? OR ? IS NULL AND 电话 IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("电话", System.Data.OleDb.OleDbType.VarWChar, 50, "电话"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("电子邮件", System.Data.OleDb.OleDbType.VarWChar, 50, "电子邮件"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("年龄", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "年龄", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("姓名", System.Data.OleDb.OleDbType.VarWChar, 50, "姓名"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_姓名", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "姓名", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电子邮件", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电子邮件", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电子邮件1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电子邮件", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电话", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_电话1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(104, 96);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 21);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(104, 128);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(160, 21);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "姓名";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "年龄";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "电话";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "电子邮件";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textBox2,
																					this.textBox1,
																					this.textBox3,
																					this.textBox4,
																					this.label1,
																					this.label2,
																					this.label3,
																					this.label4});
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 176);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "我的朋友";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "最前";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(64, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "前一个";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(168, 200);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "后一个";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(232, 200);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 23);
			this.button4.TabIndex = 12;
			this.button4.Text = "最后";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(168, 248);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 23);
			this.button5.TabIndex = 13;
			this.button5.Text = "添加记录";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(232, 248);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(64, 23);
			this.button6.TabIndex = 14;
			this.button6.Text = "删除记录";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(40, 248);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(64, 23);
			this.button7.TabIndex = 15;
			this.button7.Text = "新建";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(104, 248);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(64, 23);
			this.button8.TabIndex = 16;
			this.button8.Text = "修改";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(312, 301);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button8,
																		  this.button7,
																		  this.button6,
																		  this.button5,
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "我的通讯录";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
			//指向第一条记录
			this.myBind.Position=0;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//如果不是最前一条记录，则指针向前移动
			if (this.myBind.Position==0)
			{
				MessageBox.Show("没有前一条记录了","警告",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				this.myBind.Position--;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//如果不是最后一条记录，则指针向后移动
			if (this.myBind.Position==this.myBind.Count-1)
			{
				MessageBox.Show("没有后一条记录了","警告",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				this.myBind.Position++;;
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			//指向最后一条记录
			this.myBind.Position=this.myBind.Count-1;
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				//首先判断添加的信息是否完整
				if (this.textBox1.Text!="" & this.textBox2.Text!="" & this.textBox3.Text!="" & this.textBox4.Text!="")
				{
					//添加记录时的SQL命令
					string insert= " INSERT INTO information( 姓名,年龄 , 电话 ,电子邮件) VALUES ('" ;
					insert += this.textBox1.Text + "', '" ;
					insert += this.textBox2.Text + "', '" ;
					insert += this.textBox3.Text + "','" ;
					insert += this.textBox4.Text + "') " ;

					//初始化OleDbCommand
					OleDbCommand comm=new OleDbCommand();
					comm.CommandText=insert;
					comm.Connection=this.oleDbConnection1;
					
					//打开数据库连接
                    this.oleDbConnection1.Open();
					//执行添加记录的语句
					comm.ExecuteNonQuery();
                    //关闭记录
					this.oleDbConnection1.Close();
//
//					//更新数据集
//					this.dataSet1.Tables["information"].Rows[this.myBind.Position].BeginEdit();
//					this.dataSet1.Tables["information"].Rows[this.myBind.Position].EndEdit();
//					this.dataSet1.AcceptChanges();
//					
//					//成功提示
//					MessageBox.Show("添加记录成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
//                    this.oleDbDataAdapter1.Fill(this.dataSet1,"information");
				}
				else
				{
					//错误提示
					MessageBox.Show("请将字段信息输入完整","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			catch (Exception error)
			{
				//错误提示 
				MessageBox.Show("添加记录发生错误："+error.Message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);			
	             //如果打开了连接，则关闭
				if (this.oleDbConnection1.State==ConnectionState.Open)
				  {
				    this.oleDbConnection1.Close();
				  }
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			//确认删除记录
			if (MessageBox.Show("是否删除记录","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
			{
			
				try
				{
					    //删除记录时的SQL语句
					    string delete= " DELETE From information WHERE 姓名='" ;
						delete += this.textBox1.Text + "'" ;
						
   					    //初始化OleDbCommand
					    OleDbCommand comm=new OleDbCommand();
						comm.CommandText=delete;
						comm.Connection=this.oleDbConnection1;

					    //打开数据库连接
						this.oleDbConnection1.Open();
					    //执行删除语句
						comm.ExecuteNonQuery();
					    //关闭数据库连接
						this.oleDbConnection1.Close();
					   
					    //更新数据集
						this.dataSet1.Tables["information"].Rows[this.myBind.Position].Delete();
						this.dataSet1.AcceptChanges();
						
					    //成功提示
					    MessageBox.Show("删除记录成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.oleDbDataAdapter1.Fill(this.dataSet1,"information");
				
				}
				catch (Exception error)
				{
					//错误提示
					MessageBox.Show("删除记录发生错误："+error.Message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);			
					//如果打开了连接，则关闭
					if (this.oleDbConnection1.State==ConnectionState.Open)
					{
						this.oleDbConnection1.Close();
					}
				}		
			
	 	}			
	
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			//请空数据，准备编辑
			this.textBox1.Text="";
			this.textBox2.Text="";
			this.textBox3.Text="";
			this.textBox4.Text="";
			
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				//首先判断添加的信息是否完整
				if (this.textBox1.Text!="" & this.textBox2.Text!="" & this.textBox3.Text!="" & this.textBox4.Text!="")
				{
					//更新记录的SQL语句
					string update= " UPDATE information SET ";
					update +=  " 年龄='" ;
					update += this.textBox2.Text + "', 电话='" ;
					update += this.textBox3.Text + "', 电子邮件='" ;
					update += this.textBox4.Text + "' WHERE 姓名='" ;
					update += this.textBox1.Text + "'";

					//初始化OleDbCommand对象
					OleDbCommand comm=new OleDbCommand();
					comm.CommandText=update;
					comm.Connection=this.oleDbConnection1;

					//打开数据库连接
					this.oleDbConnection1.Open();
					//执行更新语句
					comm.ExecuteNonQuery();
					//关闭数据库连接
					this.oleDbConnection1.Close();

					//更新数据集
					this.dataSet1.Tables["information"].Rows[this.myBind.Position].BeginEdit();
					this.dataSet1.Tables["information"].Rows[this.myBind.Position].EndEdit();
					this.dataSet1.AcceptChanges();

					//成功提示
					MessageBox.Show("修改记录成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.oleDbDataAdapter1.Fill(this.dataSet1,"information");
				}
				else
				{
					//错误提示
					MessageBox.Show("请将字段信息输入完整","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			catch (Exception error)
			{
				//错误提示
				MessageBox.Show("修改记录发生错误："+error.Message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);			
				//如果打开了连接，则关闭
				if (this.oleDbConnection1.State==ConnectionState.Open)
				{
					this.oleDbConnection1.Close();
				}
			}
	
		}
	}
}
