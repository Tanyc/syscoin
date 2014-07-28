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


using BusinessLogicLayer;

public partial class Reader_ReaderMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dispUserName();
        }

    }

    void dispUserName()
    {
        Users LoginUser = new Users();
        LoginUser .UserID =Session["UserID"].ToString();
        DataSet ds= LoginUser.GetUserInfoByID(LoginUser.UserID);
        labUser .Text = ds.Tables[0].Rows[0]["userName"].ToString();
       
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("SearchBook.aspx");
    }
}
