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

using Model;
using BusinessLogicLayer;

public partial class SysAdmin_AddBook : System.Web.UI.Page
{
    BLLBook bllBook = new BLLBook();   //BLLBook必须Public


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            for (int i = 2000; i < 2008; i++)
            {
                ddlYear.Items.Add(i.ToString());
            }
            for (int i = 1; i < 13; i++)
            {
                ddlMonth.Items.Add(i.ToString());
            }
            for (int i = 1; i < 32; i++)
            {
                ddlDay.Items.Add(i.ToString());
            }
        }
        else
        { }


    }



    protected void imgBtnAdd_Click(object sender, ImageClickEventArgs e)
    {
        BookInfo bkInfo = new BookInfo();
        bkInfo.BookID = txtISBN.Text.Trim();
        bkInfo.BookName = txtName.Text.Trim();
        bkInfo.BookIndex = txtIndex.Text.Trim();
        
        bkInfo.BookTypeID =Convert .ToInt16 (rblClassify.SelectedItem.Value);

        bkInfo.Author = txtAuthor.Text.Trim();
        bkInfo.Publish = txtPublish.Text.Trim();
        bkInfo .Price =Convert .ToDouble (txtPrice .Text .Trim ());
        bkInfo.PublishDate = Convert.ToDateTime(ddlYear.SelectedItem.Text + "-" + ddlMonth.SelectedItem.Text + "-" + ddlDay.SelectedItem.Text);
        bkInfo .Abstrac=txtDescription .Text .Trim ();
        bkInfo .Keyword =txtSubject .Text .Trim ();
        bkInfo.BookStatus =1 ;
        bkInfo .RegisteDate =DateTime.Now;


        if (bllBook.AddBook(bkInfo))
            lblMessage.Text = "Add Success!!";
        else
            lblMessage.Text = "Not Add!!";

    }
}
