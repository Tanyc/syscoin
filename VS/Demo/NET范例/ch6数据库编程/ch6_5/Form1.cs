using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Data.OleDb;

using System.Xml;
namespace ch6_5
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private ch6_5.DataSet1 dataSet11;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.RichTextBox richTextBox1;
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
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataSet11 = new ch6_5.DataSet1();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT 电话, 电子邮件, 年龄, 姓名 FROM information";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=D:\Documents and Settings\administrator.TRINCE-JULIE\My Documents\person.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 336);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "读出数据";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.OldLace;
			this.dataGrid1.BackColor = System.Drawing.Color.OldLace;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.Tan;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.SaddleBrown;
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.OldLace;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dataSet11.information;
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dataGrid1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Tan;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.Wheat;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.SaddleBrown;
			this.dataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue;
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.OldLace;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.SlateGray;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(504, 168);
			this.dataGrid1.TabIndex = 2;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.dataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(80, 336);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "读出XML";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(160, 336);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "读出XML Schema";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(296, 336);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "写入XML文件";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(384, 336);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "从XML文件中载入";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 168);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(504, 3);
			this.splitter1.TabIndex = 8;
			this.splitter1.TabStop = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.richTextBox1.Location = new System.Drawing.Point(0, 171);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(504, 149);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(504, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1,
																		  this.splitter1,
																		  this.button5,
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.dataGrid1,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "DataSet与XML";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
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
			this.richTextBox1.Text="";
		    //打开数据链接
			this.oleDbConnection1.Open();
			//在dataGrid中载入数据
			this.oleDbDataAdapter1.Fill(this.dataSet11,"information");
			
            //代表数据集内容
		    string s="";
			//得到OleDbDataReader对象
			OleDbDataReader dReader=this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
			//读去数据源
			while (dReader.Read())
			{
			//读出姓名
			s+=dReader.GetString(3)+"\n";
			//读出电话
			s+=dReader.GetString(0)+"\n";
			//读出电子邮件
			s+=dReader.GetString(1)+"\n";
			//读出年龄
			s+=dReader.GetInt32(2).ToString()+"\n";			
			}
			this.richTextBox1.Text=s;	
			//关闭数据连接
			this.oleDbConnection1.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Text="";
			//打开连接
			this.oleDbConnection1.Open();
			//填充数据集
			this.oleDbDataAdapter1.Fill(this.dataSet11,"information");
			//关闭连接
			this.oleDbConnection1.Close();

			//返回数据集的XML表示形式
			string s=this.dataSet11.GetXml();
			this.richTextBox1.Text=s;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
		   
			this.richTextBox1.Text="";
			this.oleDbConnection1.Open();
			this.oleDbDataAdapter1.Fill(this.dataSet11,"information");
			this.oleDbConnection1.Close();

			//返回数据的XML表示形式的XSD架构
			string s=this.dataSet11.GetXmlSchema();
			this.richTextBox1.Text=s;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.Open();
			this.oleDbDataAdapter1.Fill(this.dataSet11,"information");
			this.oleDbConnection1.Close();
			//将数据写入Xml文件
			this.dataSet11.WriteXml("D:\\information.xml",XmlWriteMode.WriteSchema);
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
		   //创建XmlTextReader对象
		   XmlTextReader xReader= new XmlTextReader("D:\\information.xml");
		   //创建一个新的数据集
		   DataSet  ds=new DataSet();
		   //从xReader中读出数据集
		   ds.ReadXml(xReader,XmlReadMode.ReadSchema);
		   //在dataGrid中显示新的数据集
		   this.dataGrid1.DataSource=ds;	 
		}
	}
}
