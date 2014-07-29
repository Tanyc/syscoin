using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using System.Data.OleDb;

namespace MyFriend
{
	/// <summary>
	/// WebForm1 ��ժҪ˵����
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.TextBox TextBox3;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		protected System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		protected System.Data.OleDb.OleDbConnection oleDbConnection1;
		protected System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.TextBox TextBox4;
		protected System.Web.UI.WebControls.Button Button3;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ
			
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN���õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid1.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_DeleteCommand);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT �绰, �����ʼ�, ����, ���� FROM information";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
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
																																																					   new System.Data.Common.DataColumnMapping("����", "����"),
																																																					   new System.Data.Common.DataColumnMapping("����", "����"),
																																																					   new System.Data.Common.DataColumnMapping("�绰", "�绰"),
																																																					   new System.Data.Common.DataColumnMapping("�����ʼ�", "�����ʼ�")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		

		private void Button1_Click(object sender, System.EventArgs e)
		{
			DataSet ds= new DataSet();
		    OleDbCommand comm=new OleDbCommand();
			string user=this.TextBox1.Text.Trim();
			string commString="SELECT * FROM information WHERE ����='"+user+"'";
			comm.CommandText=commString;
			
			comm.Connection=this.oleDbConnection1;
			this.oleDbConnection1.Open();
			comm.ExecuteNonQuery();
			this.oleDbConnection1.Close();

			this.oleDbDataAdapter1.Fill(ds);
			this.DataGrid1.DataSource=ds;
			this.DataGrid1.DataBind();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			
		    
			OleDbCommand comm=new OleDbCommand();
			//ѡ�����еļ�¼
			string commString="SELECT * FROM information ";
			//��ʼ��OleDbCommand 
			comm.CommandText=commString;
			comm.Connection=this.oleDbConnection1;
            //ִ��ѡ�����
			this.oleDbConnection1.Open();
			comm.ExecuteNonQuery();
			this.oleDbConnection1.Close();
	        
			//���±��е�����
			DataSet ds= new DataSet();
			this.oleDbDataAdapter1.Fill(ds);
			this.DataGrid1.DataSource=ds;
			this.DataGrid1.DataBind();
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			if (this.TextBox1.Text!="" & this.TextBox2.Text!="" 
				& this.TextBox3.Text!="" & this.TextBox4.Text!="")
			{
				//��Ӽ�¼ʱ��SQL����
				string insert= " INSERT INTO information( ����,���� , �绰 ,�����ʼ�) VALUES ('" ;
				insert += this.TextBox1.Text + "', '" ;
				insert += this.TextBox2.Text + "', '" ;
				insert += this.TextBox3.Text + "','" ;
				insert += this.TextBox4.Text + "') " ;

				//��ʼ��OleDbCommand
				OleDbCommand comm=new OleDbCommand();
				comm.CommandText=insert;
				comm.Connection=this.oleDbConnection1;

				//ִ�в������
				this.oleDbConnection1.Open();
				comm.ExecuteNonQuery();
				this.oleDbConnection1.Close();
              
      
				//�������ݼ���
				DataSet ds=new DataSet();
				this.oleDbDataAdapter1.Fill(ds,"information");
				this.DataGrid1.DataSource=ds;
				this.DataGrid1.DataBind();
				this.Label6.Text="";
			}
			else
			{
			this.Label6.Text="��������ɵ��û���Ϣ";
			}

			
		}

		private void DataGrid1_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			try
			{
				
				//ɾ��һ�����
				string delete="DELETE FROM information WHERE ����='"+e.Item.Cells[4].Text+"'";
				//��ʼ��OleDbCommand
                OleDbCommand comm=new OleDbCommand();
				comm.CommandText=delete;
				comm.Connection=this.oleDbConnection1;

				//ִ��ɾ������
				this.oleDbConnection1.Open();
				comm.ExecuteNonQuery();
				this.oleDbConnection1.Close();

			    //����ҳ��
				DataSet ds=new DataSet();
				
				this.oleDbDataAdapter1.Fill(ds);
				//�����ҳɾ��ֻ��1�У�ɾ��֮���û�������ˣ���ǰҳ����Ӧ�ü�1
				this.DataGrid1.DataSource=ds;
				if (this.DataGrid1.Items.Count==1)
				{
				this.DataGrid1.CurrentPageIndex--;
				}
				this.DataGrid1.DataBind();
			}
			catch (Exception error)
			{
				//��ʾ������Ϣ
				this.Label6.Text=error.Message;
			}
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//�õ��µ�ҳ������
			int index=e.NewPageIndex;	
			//������Ϊ��ǰҳ����
			this.DataGrid1.CurrentPageIndex=index;
			//����ҳ��
		    DataSet ds=new DataSet();
	        this.oleDbDataAdapter1.Fill(ds);
			this.DataGrid1.DataSource=ds;
			this.DataBind();
		}
	}
}
