using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sUrl = txb_Url.Text.Trim();
            if (sUrl.Length > 0)
            {
                webBrowser1.Navigate(sUrl);
                this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
                webBrowser1.Refresh();//.Navigate(sUrl);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {            
            HtmlElement tbUserid = webBrowser1.Document.GetElementById("userid");
            tbUserid.SetAttribute("value", "zhanghuib");  //在这里输入邮箱的用户名

            HtmlElement tbPasswd = webBrowser1.Document.GetElementById("password");
            tbPasswd.SetAttribute("value", "zhb594188");  //在这里输入邮箱的密码

            HtmlElement btnLogin = webBrowser1.Document.GetElementById("Submit");
            btnLogin.InvokeMember("click");
            System.Threading.Thread.Sleep(1500);//异步操作，等待进入邮箱系统页面
        }               
    }
}
