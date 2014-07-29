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
	/// WebForm1 的摘要说明。
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
			// 在此处放置用户代码以初始化页
			
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN：该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
			this.oleDbSelectCommand1.CommandText = "SELECT 电话, 电子邮件, 年龄, 姓名 FROM information";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		

		private void Button1_Click(object sender, System.EventArgs e)
		{
			DataSet ds= new DataSet();
		    OleDbCommand comm=new OleDbCommand();
			string user=this.TextBox1.Text.Trim();
			string commString="SELECT * FROM information WHERE 姓名='"+user+"'";
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
			//选择所有的记录
			string commString="SELECT * FROM information ";
			//初始化OleDbCommand 
			comm.CommandText=commString;
			comm.Connection=this.oleDbConnection1;
            //执行选择语句
			this.oleDbConnection1.Open();
			comm.ExecuteNonQuery();
			this.oleDbConnection1.Close();
	        
			//更新表中的数据
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
				//添加记录时的SQL命令
				string insert= " INSERT INTO information( 姓名,年龄 , 电话 ,电子邮件) VALUES ('" ;
				insert += this.TextBox1.Text + "', '" ;
				insert += this.TextBox2.Text + "', '" ;
				insert += this.TextBox3.Text + "','" ;
				insert += this.TextBox4.Text + "') " ;

				//初始化OleDbCommand
				OleDbCommand comm=new OleDbCommand();
				comm.CommandText=insert;
				comm.Connection=this.oleDbConnection1;

				//执行插入操作
				this.oleDbConnection1.Open();
				comm.ExecuteNonQuery();
				this.oleDbConnection1.Close();
              
      
				//更新数据集合
				DataSet ds=new DataSet();
				this.oleDbDataAdapter1.Fill(ds,"information");
				this.DataGrid1.DataSource=ds;
				this.DataGrid1.DataBind();
				this.Label6.Text="";
			}
			else
			{
			this.Label6.Text="请输入完成的用户信息";
			}

			
		}

		private void DataGrid1_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			try
			{
				
				//删除一行语句
				string delete="DELETE FROM information WHERE 姓名='"+e.Item.Cells[4].Text+"'";
				//初始化OleDbCommand
                OleDbCommand comm=new OleDbCommand();
				comm.CommandText=delete;
				comm.Connection=this.oleDbConnection1;

				//执行删除操作
				this.oleDbConnection1.Open();
				comm.ExecuteNonQuery();
				this.oleDbConnection1.Close();

			    //更新页面
				DataSet ds=new DataSet();
				
				this.oleDbDataAdapter1.Fill(ds);
				//如果该页删除只有1行，删除之后就没有数据了，当前页索引应该减1
				this.DataGrid1.DataSource=ds;
				if (this.DataGrid1.Items.Count==1)
				{
				this.DataGrid1.CurrentPageIndex--;
				}
				this.DataGrid1.DataBind();
			}
			catch (Exception error)
			{
				//显示错误信息
				this.Label6.Text=error.Message;
			}
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//得到新的页面索引
			int index=e.NewPageIndex;	
			//将它设为当前页索引
			this.DataGrid1.CurrentPageIndex=index;
			//更新页面
		    DataSet ds=new DataSet();
	        this.oleDbDataAdapter1.Fill(ds);
			this.DataGrid1.DataSource=ds;
			this.DataBind();
		}
	}
}
