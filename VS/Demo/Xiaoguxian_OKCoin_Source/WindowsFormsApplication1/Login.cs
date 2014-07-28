﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnLogin();
        }

        private void OnLogin()
        {
            if (txt_Username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show(this, "用户名或密不能为空！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            
            
            LoginParm loginparm = new LoginParm();
            loginparm.Username = txt_Username.Text;
            loginparm.Password = txt_password.Text;
            
            ThreadEx threadex = new ThreadEx();
            threadex.Start(new ParameterizedThreadStart(threadex.GetLogin), (Object)loginparm, new EventHandler(GetLogin), this);
            button1.Enabled = false;
        
        }

        private void GetLogin(Object o, EventArgs e)
        {
            button1.Enabled = true;
            //Http.GetNewPrice(Http.GetHttpData(Http.GetLoginUrl()));
            //int result = Protocol.DoLogin(txt_Username.Text, txt_password.Text);

            if (Data.GetLoginResult == Define.Login_Succeed)
            {
                //Form1 form1 = new Form1();    //新建一个NewForm窗口(NewForm是自己定义的Form)
                //form1.Show();                 //新窗口显现
                this.Visible = false;           //this.ShowDialog(form1);
                //this.Dispose();               //窗口A关闭

            }
            else if (Data.GetLoginResult == Define.Login_Google)
            {

                panel_login.Visible = false;
                panel_google.Visible = true;
                txt_GoogleCheck.Focus();
                //Goolge google = new Goolge();//新建一个NewForm窗口(NewForm是自己定义的Form)
                //this.ShowDialog(google);



            }
            else if (Data.GetLoginResult != Define.Login_Google)
            {
                MessageBox.Show(this,"登录失败！","登录提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

            //httptest1.Main123();

        }

        private void GetGoogleCheck(Object o, EventArgs e)
        {
            button2.Enabled = true;
            if (Data.GetLoginResult == Define.Login_Succeed)
            {
                //Form1 form1 = new Form1();//新建一个NewForm窗口(NewForm是自己定义的Form)
                //form1.Show();           //新窗口显现
                this.Visible = false;   //this.ShowDialog(form1);
                //this.Dispose();         //窗口A关闭
            }
            else
            {
                MessageBox.Show(this, "Google验证失败！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_GoogleCheck.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Des.OpenUrl(Define.Domain);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = Define.TitleBase;
            this.MaximizeBox = false;
            //this.MaximizeBox = false;

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            panel_login.Visible = true;
            panel_google.Visible = false;

            panel_login.Top = 0;
            panel_login.Left = 0;

            panel_google.Top = 0;
            panel_google.Left = 0;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Des.OpenUrl(Define.Reset);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Des.OpenUrl(Define.QQ);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OnGoogleCheck();
        }
        private void OnGoogleCheck()
        {
            Define.GoogleCheck = txt_GoogleCheck.Text;
            if (Define.GoogleCheck != "")
            {
                GoogleCheckParm googlecheckparm = new GoogleCheckParm();
                googlecheckparm.totpCode = Define.GoogleCheck;

                ThreadEx threadex = new ThreadEx();
                threadex.Start(new ParameterizedThreadStart(threadex.GetGoogleCheck), (Object)googlecheckparm, new EventHandler(GetGoogleCheck), this);

            }
            button2.Enabled = false;
        }

        private void txt_GoogleCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                OnGoogleCheck();
            } 

        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                OnLogin();
            }   
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                OnLogin();
            }   
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            //Process process = new Process();
            process.StartInfo.FileName = "iexplore.exe";
            process.StartInfo.Arguments = Define.QQ;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            //Process process = new Process();
            process.StartInfo.FileName = "iexplore.exe";
            process.StartInfo.Arguments = Define.QQ;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            //Process process = new Process();
            process.StartInfo.FileName = "iexplore.exe";
            process.StartInfo.Arguments = Define.Domain;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            //Process process = new Process();
            process.StartInfo.FileName = "iexplore.exe";
            process.StartInfo.Arguments = Define.Reset;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }


    }
}
