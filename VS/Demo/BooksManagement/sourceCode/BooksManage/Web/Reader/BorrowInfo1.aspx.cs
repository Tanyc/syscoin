using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


using System.Data.SqlClient;
using BusinessLogicLayer;

public partial class Reader_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }

    }

    void BindData()
    {
        string userID = Session["userID"].ToString();
        DataSet dsBorrowBook = new DataSet();
        Users  user=new Users ();

        dsBorrowBook = user.GetBorrowBook(userID);

        gvBorrowBookList.DataSource = dsBorrowBook;
        gvBorrowBookList.DataBind();

    }

    protected void gvBorrowBookList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row .RowType ==DataControlRowType .DataRow )
        {
            ((Label)e.Row.Cells[2].FindControl("lblEndDate")).Text = (Convert.ToDateTime(e.Row.Cells[1].Text).AddDays(30)).ToString();
        } 


    }
}
