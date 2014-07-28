using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Web;

namespace QQWinFarm
{
    public partial class FrmFarmLogin : Form
    {
        private System.Net.CookieContainer cookie = new System.Net.CookieContainer(); 
        public FrmFarmLogin()
        {
            InitializeComponent();
        }

        // 获得验证码 
        private void GgetVerifyImage()
        {
            cookie = new System.Net.CookieContainer();
            Stream s = HttpHelper.GetStream("http://ptlogin2.qq.com/getimage?aid=15000102&0.43878429697395826", cookie);
            if (s == null)
            {
                MessageBox.Show("外挂获取登录码错误，请检查您的网络!", "提示信息");
                Application.ExitThread();
                return;
            }
            picVerify.Image = Image.FromStream(s);
            s.Close();          
        } 

        // 登录 
        public void Login()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.panel1.Enabled = false;
            });
            ChangeMessage("正在登录...");
            string username = txtQQ.Text;
            string userPWD = txtPwd.Text;
            string verifyCode = txtVerify.Text;
            string errorTxt = string.Empty;
            string strRetVal = Utils.getMd5Hash2(Utils.getMd5Hash(userPWD).ToUpper() + verifyCode.ToUpper()).ToUpper();
            string postData = "u=" + username + "&p=" + strRetVal + "&verifycode=" + verifyCode + "&aid=15000101&u1=http%3A%2F%2Fphp.qzone.qq.com%2Findex.php%3Fmod%3Dportal%26act%3Dlogin&fp=loginerroralert&h=1&ptredirect=1&ptlang=0&from_ui=1&dumy=";
            string result = HttpHelper.GetHtml("http://ptlogin2.qq.com/login", postData, true, cookie);
            errorTxt = result;
            result = HttpHelper.GetHtml("http://php.qzone.qq.com/index.php?mod=portal&act=login", cookie);
            bool isLogin = result.Contains("g_iLoginUin = " + username);
            if (!isLogin)
            {
                if (result.Contains("完成跳转"))
                {
                    ChangeMessage("登录成功");
                    isLogin = true;
                }
                else
                {
                    if (!isLogin)
                    {
                        if (result.Contains("g_iLoginUin=" + username))
                        {
                            ChangeMessage("登录成功");
                            isLogin = true;
                        }
                        else
                        {
                            errorTxt = Utils.NoHTML(errorTxt);
                            isLogin = false;
                        }
                    }
                }
            }
            else
            {
                ChangeMessage("登录成功");
                isLogin = true;
            }
            if (isLogin)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Hide();
                    FrmFarmMain fncm = new FrmFarmMain(cookie);
                    fncm.Show();
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Text = errorTxt;
                    this.txtVerify.Text = "";
                    MessageBox.Show(errorTxt, "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Invoke((MethodInvoker)delegate
                    {
                        GgetVerifyImage();
                        this.panel1.Enabled = true;
                    });
                    btnLogin.Text = "登录农场";
                });
            }
        }
        private void butVerify_Click(object sender, EventArgs e)
        {
            GgetVerifyImage();
        }

        private void FrmFarmLogin_Load(object sender, EventArgs e)
        {        
            GgetVerifyImage();         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Login));
            thread.IsBackground = true;
            thread.Start();
        }
        private void ChangeMessage(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Text = message;
            });
        }

        private void txtVerify_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Thread thread = new Thread(new ThreadStart(Login));
                thread.IsBackground = true;
                thread.Start();
            } 
        }

        private void FrmFarmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void txtVerify_KeyPress(object sender, KeyPressEventArgs e)
        {
            char asdasd = e.KeyChar;
            if (asdasd == ',')
            { }
        }
    }
}
