using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading;

namespace WindowsFormsApplication
{
    public partial class Assets : Form
    {
        public Assets()
        {
            InitializeComponent();
        }

        private void Assets_Load(object sender, EventArgs e)
        {

            this.Text = Define.TitleBase;
            this.MaximizeBox = false;
            //this.MaximizeBox = false;

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;


            ThreadEx threadex23 = new ThreadEx();
            threadex23.Start(new ThreadStart(threadex23.GetAssets), new EventHandler(GetAssets), this);
        }



        private void GetAssets(Object o, EventArgs e)
        {
            if (Data.GetUserInfoResult == Define.Login_Succeed)
            {

                lock (Data.free)
                {
                    lab_trading_account_net.Text = Data.free["cny"].ToString(); ;
                }
                

                lock (Data.freeall)
                {
                    lab_trading_account_total.Text = Data.freeall["all"].ToString();
                }


                lock (Data.lending_account)
                {

                    lab_lending_account_available_btc.Text = Data.lending_account["available"]["btc"].ToString();
                    lab_lending_account_available_cny.Text = Data.lending_account["available"]["cny"].ToString();
                    lab_lending_account_available_ltc.Text = Data.lending_account["available"]["ltc"].ToString();

                    //////////////////////////////////////////////////////////////////////////////////////////

                    lab_lending_account_frozen_btc.Text = Data.lending_account["frozen"]["btc"].ToString();
                    lab_lending_account_frozen_cny.Text = Data.lending_account["frozen"]["cny"].ToString();
                    lab_lending_account_frozen_ltc.Text = Data.lending_account["frozen"]["ltc"].ToString();

                    //////////////////////////////////////////////////////////////////////////////////////////

                    lab_lending_account_lent_btc.Text = Data.lending_account["lent"]["btc"].ToString();
                    lab_lending_account_lent_cny.Text = Data.lending_account["lent"]["cny"].ToString();
                    lab_lending_account_lent_ltc.Text = Data.lending_account["lent"]["ltc"].ToString();

                    //////////////////////////////////////////////////////////////////////////////////////////

                    lab_trading_account_net.Text = Data.trading_account_child["net"].ToString("0.00");
                    lab_lending_account_total.Text = Data.lending_account_child["total"].ToString("0.00");
                                        
                }


                lock (Data.trading_account)
                {

                    lab_trading_account_available_btc.Text = Data.trading_account["available"]["btc"].ToString();
                    lab_trading_account_available_cny.Text = Data.trading_account["available"]["cny"].ToString();
                    lab_trading_account_available_ltc.Text = Data.trading_account["available"]["ltc"].ToString();
                    
                    //////////////////////////////////////////////////////////////////////////////////////////

                    lab_trading_account_frozen_btc.Text = Data.trading_account["frozen"]["btc"].ToString();
                    lab_trading_account_frozen_cny.Text = Data.trading_account["frozen"]["cny"].ToString();
                    lab_trading_account_frozen_ltc.Text = Data.trading_account["frozen"]["ltc"].ToString();

                    //////////////////////////////////////////////////////////////////////////////////////////

                    lab_trading_account_borrowed_btc.Text = Data.trading_account["borrowed"]["btc"].ToString();
                    lab_trading_account_borrowed_cny.Text = Data.trading_account["borrowed"]["cny"].ToString();
                    lab_trading_account_borrowed_ltc.Text = Data.trading_account["borrowed"]["ltc"].ToString();

                    //////////////////////////////////////////////////////////////////////////////////////////
                    
                    lab_trading_account_total.Text = Data.trading_account_child["total"].ToString("0.00");
                                        
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
