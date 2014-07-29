using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Data.OleDb;

namespace ch6_1
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.DataSet dataSet1;

		private BindingManagerBase myBind;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
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
			

			DataBinding();

		

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		private void DataBinding()
	    {
	
            //ˢ�����ݼ�
			this.oleDbDataAdapter1.Fill(this.dataSet1,"information");

            //���ݰ�
			this.textBox1.DataBindings.Add("Text",this.dataSet1,"information.����");
			this.textBox2.DataBindings.Add("Text",this.dataSet1,"information.����");
			this.textBox3.DataBindings.Add("Text",this.dataSet1,"information.�绰");
			this.textBox4.DataBindings.Add("Text",this.dataSet1,"information.�����ʼ�");	
			
			

			//����
			myBind=this.BindingContext[this.dataSet1,"information"];
		
	   
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
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet1 = new System.Data.DataSet();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=D:\Documents and Settings\administrator.TRINCE-JULIE\My Documents\person.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textBox4,
																					this.textBox3,
																					this.textBox2,
																					this.textBox1,
																					this.label4,
																					this.label3,
																					this.label2,
																					this.label1});
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 168);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "�ҵ�����";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(96, 124);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(152, 21);
			this.textBox4.TabIndex = 8;
			this.textBox4.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(96, 92);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 21);
			this.textBox3.TabIndex = 7;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(96, 58);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 21);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(96, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 21);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "�����ʼ�";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "�绰";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "����";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "����";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(72, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "ǰһ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(144, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 24);
			this.button2.TabIndex = 3;
			this.button2.Text = "��һ��";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "information", new System.Data.Common.DataColumnMapping[] {
																																																					   new System.Data.Common.DataColumnMapping("����", "����"),
																																																					   new System.Data.Common.DataColumnMapping("����", "����"),
																																																					   new System.Data.Common.DataColumnMapping("�绰", "�绰"),
																																																					   new System.Data.Common.DataColumnMapping("�����ʼ�", "�����ʼ�")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM information WHERE (���� = ?) AND (�����ʼ� = ? OR ? IS NULL AND �����ʼ� IS NUL" +
				"L) AND (�绰 = ? OR ? IS NULL AND �绰 IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�����ʼ�", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����ʼ�", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�����ʼ�1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����ʼ�", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�绰", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�绰1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO information(�绰, �����ʼ�, ����, ����) VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("�绰", System.Data.OleDb.OleDbType.VarWChar, 50, "�绰"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("�����ʼ�", System.Data.OleDb.OleDbType.VarWChar, 50, "�����ʼ�"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 50, "����"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT �绰, �����ʼ�, ����, ���� FROM information";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE information SET �绰 = ?, �����ʼ� = ?, ���� = ?, ���� = ? WHERE (���� = ?) AND (�����ʼ� " +
				"= ? OR ? IS NULL AND �����ʼ� IS NULL) AND (�绰 = ? OR ? IS NULL AND �绰 IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("�绰", System.Data.OleDb.OleDbType.VarWChar, 50, "�绰"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("�����ʼ�", System.Data.OleDb.OleDbType.VarWChar, 50, "�����ʼ�"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 50, "����"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�����ʼ�", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����ʼ�", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�����ʼ�1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����ʼ�", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�绰", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�绰1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(216, 200);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 24);
			this.button3.TabIndex = 4;
			this.button3.Text = "���";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(8, 200);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 24);
			this.button4.TabIndex = 5;
			this.button4.Text = "��ǰ";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 245);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "�ҵ�ͨѶ¼";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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
			//���������ǰһ����¼����ָ����ǰ�ƶ�
			if (this.myBind.Position==0)
			{
				MessageBox.Show("û��ǰһ����¼��","����",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				this.myBind.Position--;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//����������һ����¼����ָ������ƶ�
			if (this.myBind.Position==this.myBind.Count-1)
			{
				MessageBox.Show("û�к�һ����¼��","����",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				this.myBind.Position++;;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//ָ�����һ����¼
			this.myBind.Position=this.myBind.Count-1;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			//ָ���һ����¼
			this.myBind.Position=0;
		}
	}
}
