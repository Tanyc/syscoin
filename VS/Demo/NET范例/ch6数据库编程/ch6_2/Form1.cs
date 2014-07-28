using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Data.SqlClient;

namespace ch6_2
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
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

			InitialComboBox();
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void InitialComboBox()
		{
		    //填充数据集
			this.sqlDataAdapter1.Fill(this.dataSet1,"Customers");
			//设置comboBox的绑定属性
			this.comboBox1.DataSource=this.dataSet1;
			this.comboBox1.DisplayMember="Customers.ContactName";
			this.comboBox1.ValueMember="Customers.ContactName";
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataSet1 = new System.Data.DataSet();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "选择顾客名字";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(152, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(136, 20);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textBox11,
																					this.textBox10,
																					this.textBox9,
																					this.textBox8,
																					this.textBox7,
																					this.textBox6,
																					this.textBox5,
																					this.textBox4,
																					this.textBox3,
																					this.textBox2,
																					this.textBox1,
																					this.label12,
																					this.label11,
																					this.label10,
																					this.label9,
																					this.label8,
																					this.label7,
																					this.label6,
																					this.label5,
																					this.label4,
																					this.label3,
																					this.label2});
			this.groupBox1.Location = new System.Drawing.Point(24, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 296);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "顾客详细信息";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "CustomerID";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 18);
			this.label3.TabIndex = 1;
			this.label3.Text = "CompanyName";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "ContactName";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 18);
			this.label5.TabIndex = 3;
			this.label5.Text = "ContactTitle";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 18);
			this.label6.TabIndex = 4;
			this.label6.Text = "Address";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 18);
			this.label7.TabIndex = 5;
			this.label7.Text = "City";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 168);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 18);
			this.label8.TabIndex = 6;
			this.label8.Text = "Region";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 192);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 18);
			this.label9.TabIndex = 7;
			this.label9.Text = "PostalCode";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 216);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 18);
			this.label10.TabIndex = 8;
			this.label10.Text = "Country";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 240);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 18);
			this.label11.TabIndex = 9;
			this.label11.Text = "Phone";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 264);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 18);
			this.label12.TabIndex = 10;
			this.label12.Text = "Fax";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(128, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(136, 21);
			this.textBox1.TabIndex = 11;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(128, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(136, 21);
			this.textBox2.TabIndex = 12;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(128, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(136, 21);
			this.textBox3.TabIndex = 13;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(128, 96);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(136, 21);
			this.textBox4.TabIndex = 14;
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(128, 120);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(136, 21);
			this.textBox5.TabIndex = 15;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(128, 144);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(136, 21);
			this.textBox6.TabIndex = 16;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(128, 168);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(136, 21);
			this.textBox7.TabIndex = 17;
			this.textBox7.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(128, 192);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(136, 21);
			this.textBox8.TabIndex = 18;
			this.textBox8.Text = "";
			// 
			// textBox9
			// 
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Location = new System.Drawing.Point(128, 216);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(136, 21);
			this.textBox9.TabIndex = 19;
			this.textBox9.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Location = new System.Drawing.Point(128, 240);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(136, 21);
			this.textBox10.TabIndex = 20;
			this.textBox10.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Location = new System.Drawing.Point(128, 264);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(136, 21);
			this.textBox11.TabIndex = 21;
			this.textBox11.Text = "";
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "data source=TRINCE-JULIE\\NetSDK;initial catalog=Northwind;integrated security=SSP" +
				"I;persist security info=False;workstation id=TRINCE-JULIE;packet size=4096";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
																																																				   new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
																																																				   new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
																																																				   new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
																																																				   new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																				   new System.Data.Common.DataColumnMapping("City", "City"),
																																																				   new System.Data.Common.DataColumnMapping("Region", "Region"),
																																																				   new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
																																																				   new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																				   new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																				   new System.Data.Common.DataColumnMapping("Fax", "Fax")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
				" PostalCode, Country, Phone, Fax FROM Customers";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax); SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, Phone = @Phone, Fax = @Fax WHERE (CustomerID = @Original_CustomerID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL); SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM Customers WHERE (CustomerID = @Original_CustomerID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.comboBox1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "查询顾客信息";
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.groupBox1.ResumeLayout(false);
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

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//获得顾客名称
			string s=this.comboBox1.Text;
			//对具体显示顾客信息的组件进行数据绑定
			DataBinding(s);
		}

		private void DataBinding(string name)
  		{
             //设置查询字符串
			 string commString="SELECT * From Customers WHERE "+ "ContactName="+"'"+name+"'";
			 //新建一个SqlCommand对象
			 SqlCommand comm=new SqlCommand() ;
		     //设置SqlCommand对象的查询语句
			 comm.CommandText=commString;  
			 //设置SqlCommand对象的连接
			 comm.Connection=this.sqlConnection1;

		     //新建一个数据集存贮查询结果   
		 	 DataSet dataSet2=new DataSet();
			 //改变数据适配器对象的查询语句 
			 this.sqlDataAdapter1.SelectCommand=comm;
			 //填充数据集
			 this.sqlDataAdapter1.Fill(dataSet2,"Customers");

             //具体对每个控件进行数据绑定
			 //绑定前要清空以前的绑定
        	 this.textBox1.DataBindings.Clear();
			 this.textBox1.DataBindings.Add("Text",dataSet2,"Customers.CustomerID");
			 this.textBox2.DataBindings.Clear();
			 this.textBox2.DataBindings.Add("Text",dataSet2,"Customers.CompanyName");
			 this.textBox3.DataBindings.Clear();
			 this.textBox3.DataBindings.Add("Text",dataSet2,"Customers.ContactName");
			 this.textBox4.DataBindings.Clear();
			 this.textBox4.DataBindings.Add("Text",dataSet2,"Customers.ContactTitle");
			 this.textBox5.DataBindings.Clear();
			 this.textBox5.DataBindings.Add("Text",dataSet2,"Customers.Address");
    		 this.textBox6.DataBindings.Clear();
 			 this.textBox6.DataBindings.Add("Text",dataSet2,"Customers.City");
			 this.textBox7.DataBindings.Clear();
			 this.textBox7.DataBindings.Add("Text",dataSet2,"Customers.Region");
			 this.textBox8.DataBindings.Clear();
			 this.textBox8.DataBindings.Add("Text",dataSet2,"Customers.PostalCode");
    		 this.textBox9.DataBindings.Clear();
			 this.textBox9.DataBindings.Add("Text",dataSet2,"Customers.Country");
			 this.textBox10.DataBindings.Clear();
			 this.textBox10.DataBindings.Add("Text",dataSet2,"Customers.Phone");
			 this.textBox11.DataBindings.Clear();
			 this.textBox11.DataBindings.Add("Text",dataSet2,"Customers.Fax");
		}
	}
}
