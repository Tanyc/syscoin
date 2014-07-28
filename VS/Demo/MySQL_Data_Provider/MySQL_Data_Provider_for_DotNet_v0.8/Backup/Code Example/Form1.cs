using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.MySQLClient;
using System.Runtime.InteropServices;
using System.IO;


namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region DesignerCrap
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//dataGrid1.TableStyles.Add(new DataGridColumnStyle
		}



		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtInitialDB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtHost = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label6 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label9 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnStoreUnicode = new System.Windows.Forms.Button();
			this.txtUnicode = new System.Windows.Forms.TextBox();
			this.btnGetASCII = new System.Windows.Forms.Button();
			this.btnGetUnicode = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.btnAbort = new System.Windows.Forms.Button();
			this.btnCommit = new System.Windows.Forms.Button();
			this.btnReadForTrans = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2,
																					  this.tabPage3,
																					  this.tabPage4,
																					  this.tabPage5});
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(504, 448);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.label10,
																				   this.btnConnect,
																				   this.label4,
																				   this.txtInitialDB,
																				   this.label3,
																				   this.label2,
																				   this.label1,
																				   this.txtPassword,
																				   this.txtUser,
																				   this.txtHost});
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(496, 422);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Connection";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(120, 128);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(224, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "Connect first!!!";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(16, 128);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(88, 23);
			this.btnConnect.TabIndex = 16;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.TabIndex = 15;
			this.label4.Text = "Initial DB";
			// 
			// txtInitialDB
			// 
			this.txtInitialDB.Location = new System.Drawing.Point(120, 88);
			this.txtInitialDB.Name = "txtInitialDB";
			this.txtInitialDB.TabIndex = 14;
			this.txtInitialDB.Text = "test";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 13;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 12;
			this.label2.Text = "User";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 11;
			this.label1.Text = "Host";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(120, 64);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.TabIndex = 10;
			this.txtPassword.Text = "";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(120, 40);
			this.txtUser.Name = "txtUser";
			this.txtUser.TabIndex = 9;
			this.txtUser.Text = "root";
			// 
			// txtHost
			// 
			this.txtHost.Location = new System.Drawing.Point(120, 16);
			this.txtHost.Name = "txtHost";
			this.txtHost.TabIndex = 8;
			this.txtHost.Text = "localhost";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.dataGrid1,
																				   this.label6,
																				   this.btnUpdate,
																				   this.btnSelect,
																				   this.label5});
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(496, 422);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "DataSet & DataGrid";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 104);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(464, 304);
			this.dataGrid1.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(472, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "UPDATE user SET Alias=?, Name=?, UserType=?, Rating=?, BirthDay=? WHERE UserID=?";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(120, 64);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 23);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update data";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(16, 64);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(88, 23);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "Retrieve data";
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(352, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "SELECT * FROM User";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.label9,
																				   this.listBox1,
																				   this.label7,
																				   this.btnStoreUnicode,
																				   this.txtUnicode,
																				   this.btnGetASCII,
																				   this.btnGetUnicode});
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(496, 422);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Unicode";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(160, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(320, 40);
			this.label9.TabIndex = 6;
			this.label9.Text = "Store some unicode text in UTF-8 format in database, then retreive either Unicode" +
				" or ASCII.";
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(24, 160);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(456, 251);
			this.listBox1.TabIndex = 5;
			this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(328, 23);
			this.label7.TabIndex = 4;
			this.label7.Text = "Some Unicode (doubleclick to insert into textbox)";
			// 
			// btnStoreUnicode
			// 
			this.btnStoreUnicode.Location = new System.Drawing.Point(24, 96);
			this.btnStoreUnicode.Name = "btnStoreUnicode";
			this.btnStoreUnicode.Size = new System.Drawing.Size(120, 23);
			this.btnStoreUnicode.TabIndex = 2;
			this.btnStoreUnicode.Text = "Store Text";
			this.btnStoreUnicode.Click += new System.EventHandler(this.btnStoreUnicode_Click);
			// 
			// txtUnicode
			// 
			this.txtUnicode.Location = new System.Drawing.Point(160, 96);
			this.txtUnicode.Name = "txtUnicode";
			this.txtUnicode.Size = new System.Drawing.Size(320, 20);
			this.txtUnicode.TabIndex = 3;
			this.txtUnicode.Text = "";
			// 
			// btnGetASCII
			// 
			this.btnGetASCII.Location = new System.Drawing.Point(24, 56);
			this.btnGetASCII.Name = "btnGetASCII";
			this.btnGetASCII.Size = new System.Drawing.Size(120, 23);
			this.btnGetASCII.TabIndex = 1;
			this.btnGetASCII.Text = "Retrieve ASCII";
			this.btnGetASCII.Click += new System.EventHandler(this.btnGetASCII_Click);
			// 
			// btnGetUnicode
			// 
			this.btnGetUnicode.Location = new System.Drawing.Point(24, 16);
			this.btnGetUnicode.Name = "btnGetUnicode";
			this.btnGetUnicode.Size = new System.Drawing.Size(120, 23);
			this.btnGetUnicode.TabIndex = 0;
			this.btnGetUnicode.Text = "Retrieve Unicode";
			this.btnGetUnicode.Click += new System.EventHandler(this.btnGetUnicode_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.btnSave,
																				   this.btnLoad});
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(496, 422);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Blobs";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(16, 56);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(184, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Retrieve file from DB and save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(16, 16);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(184, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Load file and store in DB";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.label8,
																				   this.dataGrid2,
																				   this.btnAbort,
																				   this.btnCommit,
																				   this.btnReadForTrans});
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(496, 422);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Transactions";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(144, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(328, 32);
			this.label8.TabIndex = 4;
			this.label8.Text = "Retrieve data, change  some fields, commit or rollback and retrieve again to chec" +
				"k.";
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(16, 96);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(464, 312);
			this.dataGrid2.TabIndex = 3;
			// 
			// btnAbort
			// 
			this.btnAbort.Location = new System.Drawing.Point(112, 56);
			this.btnAbort.Name = "btnAbort";
			this.btnAbort.TabIndex = 2;
			this.btnAbort.Text = "Rollback";
			this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
			// 
			// btnCommit
			// 
			this.btnCommit.Location = new System.Drawing.Point(16, 56);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.TabIndex = 1;
			this.btnCommit.Text = "Commit";
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// btnReadForTrans
			// 
			this.btnReadForTrans.Location = new System.Drawing.Point(16, 16);
			this.btnReadForTrans.Name = "btnReadForTrans";
			this.btnReadForTrans.Size = new System.Drawing.Size(112, 23);
			this.btnReadForTrans.TabIndex = 0;
			this.btnReadForTrans.Text = "Retrieve Data";
			this.btnReadForTrans.Click += new System.EventHandler(this.btnReadForTrans_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "doc1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 461);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}


		private void Form1_Load(object sender, System.EventArgs e)
		{
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("ar").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("be").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("el").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("fa").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("he").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("hi").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("kok").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("mr").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("sa").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("ta").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("th").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("ur").NativeName);
			listBox1.Items.Add(CultureInfo.CreateSpecificCulture("vi").NativeName);
		}
		#endregion

		//********************************************************************************

		#region Declarations
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtInitialDB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Button btnConnect;

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGrid dataGrid1;

		bool m_blnConnected = false;
		MySQLConnection m_objCon = new MySQLConnection();
		MySQLDataAdapter m_objDA = new MySQLDataAdapter();
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnGetUnicode;
		private System.Windows.Forms.Button btnGetASCII;
		private System.Windows.Forms.TextBox txtUnicode;
		private System.Windows.Forms.Button btnStoreUnicode;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnReadForTrans;
		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.Button btnAbort;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		DataSet m_objDS;
		#endregion


		#region Connect to database
		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (!m_blnConnected)
				{
					m_objCon.ConnectionString = "Location=" + txtHost.Text + ";User ID=" + txtUser.Text + ";Password=" + txtPassword.Text + ";Data Source=" + txtInitialDB.Text;
					m_objCon.Open();
					btnConnect.Text = "Disconnect";
					m_blnConnected = true;
					MessageBox.Show(m_objCon.State.ToString());
				} 
				else 
				{
					m_objCon.Close();
					btnConnect.Text = "Connect";
					m_blnConnected = false;
					MessageBox.Show(m_objCon.State.ToString());
				}
			}
			catch (Exception ex)
			{
				m_objCon.Close();
				btnConnect.Text = "Connect";
				m_blnConnected = false;
				MessageBox.Show(ex.ToString());
				MessageBox.Show(m_objCon.State.ToString());
			}
		}
		#endregion


		#region DataSet & DataGrid
		private void btnSelect_Click(object sender, System.EventArgs e)
		{
			try
			{
				m_objDA.SelectCommand = new MySQLCommand("SELECT * FROM user", m_objCon);
				m_objDA.UpdateCommand = new MySQLCommand("UPDATE user SET Alias=?, Name=?, UserType=?, Rating=?, BirthDay=? WHERE UserID=?", m_objCon);
				m_objDA.UpdateCommand.Parameters.Add("Alias");
				m_objDA.UpdateCommand.Parameters.Add("Name");
				m_objDA.UpdateCommand.Parameters.Add("UserType");
				m_objDA.UpdateCommand.Parameters.Add("Rating");
				m_objDA.UpdateCommand.Parameters.Add("Birthday");
				m_objDA.UpdateCommand.Parameters.Add("UserID");
				m_objDA.UpdateCommand.Parameters[m_objDA.UpdateCommand.Parameters.Count - 1].SourceVersion = DataRowVersion.Original;
				
				m_objDS = new DataSet();
				m_objDA.Fill(m_objDS, "user");
				dataGrid1.DataSource = m_objDS.Tables["user"];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			try
			{
				m_objDA.Update(m_objDS, "User");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion

		
		#region Unicode
		private void listBox1_DoubleClick(object sender, System.EventArgs e)
		{
			string strTemp = txtUnicode.Text;
			txtUnicode.Text = strTemp.Substring(0, txtUnicode.SelectionStart) + listBox1.Text + strTemp.Substring(txtUnicode.SelectionStart, strTemp.Length - txtUnicode.SelectionStart);
		}


		private void btnGetUnicode_Click(object sender, System.EventArgs e)
		{
			MySQLCommand objCommand = new MySQLCommand("SELECT Text FROM testunicode", m_objCon);
			objCommand.UseUnicode = true;

			string strTemp = objCommand.ExecuteScalar().ToString();
			txtUnicode.Text = strTemp;
			MessageBox.Show(strTemp);
		}


		private void btnGetASCII_Click(object sender, System.EventArgs e)
		{
			MySQLCommand objCommand = new MySQLCommand("SELECT Text FROM testunicode", m_objCon);
			objCommand.UseUnicode = false;

			string strTemp = objCommand.ExecuteScalar().ToString();
			txtUnicode.Text = strTemp;
			MessageBox.Show(strTemp);
		}


		private void btnStoreUnicode_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySQLCommand objCommand = new MySQLCommand("UPDATE testunicode SET Text=? WHERE ID=1", m_objCon);
				objCommand.UseUnicode = true;
				objCommand.Parameters.Add("Text", DbType.String, txtUnicode.Text);
				objCommand.ExecuteNonQuery();
				MessageBox.Show("Saved");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion


		#region Blobs
		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			try
			{
				openFileDialog1.ShowDialog();
				Stream objFile = openFileDialog1.OpenFile();

				byte[] bteTemp = new Byte[objFile.Length];
				objFile.BeginRead(bteTemp, 0, bteTemp.Length, null, null);

				MySQLCommand objCommand = new MySQLCommand("UPDATE testtable SET Text=? WHERE ID=1", m_objCon);
				objCommand.Parameters.Add("Text", DbType.Binary, bteTemp);
				objCommand.ExecuteNonQuery();
				MessageBox.Show("Stored in DB");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				saveFileDialog1.ShowDialog();
				Stream objFile = saveFileDialog1.OpenFile();

				MySQLCommand objCommand = new MySQLCommand("SELECT Text FROM testtable", m_objCon);
				byte[] bteTemp = (byte[]) objCommand.ExecuteScalar();

				objFile.BeginWrite(bteTemp, 0, bteTemp.Length, null, null);
				MessageBox.Show("Saved as file");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion


		#region Transactions
		private void btnReadForTrans_Click(object sender, System.EventArgs e)
		{
			try
			{
				m_objDA.SelectCommand = new MySQLCommand("SELECT * FROM user", m_objCon);
				m_objDA.UpdateCommand = new MySQLCommand("UPDATE user SET Alias=?, Name=?, UserType=?, Rating=?, BirthDay=? WHERE UserID=?", m_objCon);
				m_objDA.UpdateCommand.Parameters.Add("Alias");
				m_objDA.UpdateCommand.Parameters.Add("Name");
				m_objDA.UpdateCommand.Parameters.Add("UserType");
				m_objDA.UpdateCommand.Parameters.Add("Rating");
				m_objDA.UpdateCommand.Parameters.Add("Birthday");
				m_objDA.UpdateCommand.Parameters.Add("UserID");

				m_objDS = new DataSet();
				m_objDA.Fill(m_objDS, "User");
				dataGrid2.DataSource = m_objDS.Tables["User"];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void btnCommit_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySQLTransaction objTransaction = m_objCon.BeginTransaction();
				m_objDA.Update(m_objDS, "User");
				objTransaction.Commit();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		private void btnAbort_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySQLTransaction objTransaction = m_objCon.BeginTransaction();
				m_objDA.Update(m_objDS, "User");
				objTransaction.Rollback();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion
	}
}
