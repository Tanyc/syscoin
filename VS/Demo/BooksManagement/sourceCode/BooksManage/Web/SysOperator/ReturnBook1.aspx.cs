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

public partial class SysOperator_ReturnBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.txtBookID.Focus();

    }
    protected void ImageReset_Click(object sender, ImageClickEventArgs e)
    {
        txtBookID.Text = string.Empty;
        lblMsg.Text =string.Empty;
    }
    protected void imgbtnReturn_Click(object sender, ImageClickEventArgs e)
    {
        BookBusiness bookBuz=new BookBusiness();
        string bookID = txtBookID.Text.ToString().Trim();


        if (bookBuz.CheckBookByID(bookID) == 0)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "输入图书编号有误！！";

        }

        else
        {
            bookBuz.ReturnBook(bookID);
            lblMsg.Visible = true;
            lblMsg.Text = "还书成功！！";
        }


    }
}
