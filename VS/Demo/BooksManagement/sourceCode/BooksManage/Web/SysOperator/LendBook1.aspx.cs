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

public partial class SysOperator_LendBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.txtReaderID.Focus();

    }

    protected void imgbtnLend_Click(object sender, ImageClickEventArgs e)
    {
        string bookID = txtBookID.Text.ToString().Trim();
        string userID = txtReaderID.Text.ToString().Trim();
        BookBusiness BB = new BookBusiness();
        if (BB.CheckBookByID(bookID) == 0)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "不存在该书籍！！";


        }
        else if (BB.CheckBookByID(bookID) == -1)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "该书籍已借出或在维护中！！";



        }

        else
        {


            int val = BookBusiness.LendBook(userID, bookID);

            if (val == 1)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "借阅成功";
            }


        }




    }
    protected void ImageReset_Click(object sender, ImageClickEventArgs e)
    {
        txtReaderID.Text = string.Empty;
        txtBookID.Text = string.Empty;
        lblMsg.Text = string.Empty;
    }

}

    
