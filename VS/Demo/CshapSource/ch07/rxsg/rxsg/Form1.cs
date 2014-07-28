using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FluorineFx.IO;
using FluorineFx.Messaging.Messages;
using System.Text.RegularExpressions;//处理正则表达式的命名空间
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using Games;

namespace rxsg
{
    public partial class sgForm : Form
    {
        public Sanguo sg = new Sanguo();
        public string passUrl = "";
        public Sanguo.CampaignArmy tArmy = new Sanguo.CampaignArmy();
        public Dictionary<int, Double> mResource = new Dictionary<int, Double>();
        public bool selectCity = false;
        public int MarchLevel = 0;
        public int CarryLevel = 0;
        public int ReinLevel = 0;
        public int DakLevel = 0;
        public int HeroSpeedAddOn = 0, Heroid = 0;
        public Point Sourcesite, Targetsite;
        public long mPathTime = 0, mRestTime = 0;
        public long UseFood = 0, totalCarry = 0;
        public Dictionary<int, List<object[]>> GrowTable = new Dictionary<int, List<object[]>>();
        public Dictionary<int, List<object>> TimerList = new Dictionary<int, List<object>>();
        public Dictionary<int, System.Threading.Timer> TimerTable = new Dictionary<int, System.Threading.Timer>();
        public List<object> tmpList = new List<object>();
        public List<int> GrowCityBuildList = new List<int>();
        public int[] row, zhanl_row;
        public System.Threading.Timer tmpTimer;
        public static int count = 0;
    
        public sgForm()
        {
            InitializeComponent();
        }
      
        private void sgForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (sg.mHooked == false)
                sg.HookNetwork();
            else
            {
                timer1.Enabled = false;
                string gameserver = Sanguo.IECookieString;
                gameserver = gameserver.Substring(gameserver.IndexOf("Referer: "));// gameserver.IndexOf(");
                gameserver = gameserver.Substring(0, gameserver.IndexOf("BloodWar"));
                Sanguo.GameUIAddress = gameserver.Replace("Referer: ", "");
                textBox2.AppendText(Sanguo.GameUIAddress + "\r\n");

                if (Sanguo.MsgPassword.Equals("WAIGUASB"))
                {
                    Sanguo.GetNewHead(Sanguo.GameUIAddress);
                    sg.Getswf();
                    WebBrowser web = new WebBrowser();
                    web.Navigate(@"c:\rxsg\html\app1.html");
                    bool isFinish = false;
                    textBox2.AppendText(Sanguo.swfPassfile + "\r\n");
                    while (isFinish == false)
                    {
                        Application.DoEvents();
                        if (web.Document.GetElementById("code").GetAttribute("value").Equals("abc"))
                            isFinish = false;
                        else
                        {
                            isFinish = true;
                            Sanguo.MsgPassword = web.Document.GetElementById("code").GetAttribute("value");
                            textBox2.AppendText(Sanguo.MsgPassword + "\r\n");
                            web.Dispose();
                        }
                        Thread.Sleep(0);
                    }
                }

                sg.GetUserCities();
                for (int i = 0; i < sg.LoginUser.UserCities.Length; i++)
                {
                    sg.GetCityInfo(sg.LoginUser.UserCities[i].cityid);
                    com.Items.Add(sg.LoginUser.UserCities[i].name);
                }
                this.Text = "欢迎 " + "【" + sg.LoginUser.username + "】" + " 使用" + this.Text;
                this.Text += " " + "编号：" + sg.LoginUser.UserID;
                sg.setArmyInfo();
            }
        }
                
        private void com_TextChanged_1(object sender, EventArgs e)
        {
            if (sg.LoginUser.UserCities[com.SelectedIndex].Technology.ContainsKey("12"))
                MarchLevel = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Technology["12"]); //as TechInfo).Level : 0
            if (sg.LoginUser.UserCities[com.SelectedIndex].Technology.ContainsKey("13"))
                ReinLevel = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Technology["13"]);
            if(sg.LoginUser.UserCities[com.SelectedIndex].Technology.ContainsKey("16"))
                CarryLevel=Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Technology["16"]);
            
            tArmy.init();
            Sourcesite = Sanguo.Cid2Point(Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].cityid));
            Targetsite = Sanguo.Cid2Point(Convert.ToInt32(Target_Y.Value) * 1000 + Convert.ToInt32(Target_X.Value));
            Heroscom.Items.Clear();
            Heroscom.Items.Add("――");

            foreach (var tmpBuild in sg.LoginUser.UserCities[com.SelectedIndex].Builders.Values)
            {
                if ((tmpBuild as Sanguo.BuildInfo).BuildID == 18)
                {
                    DakLevel = (tmpBuild as Sanguo.BuildInfo).level;
                    break;
                }
            }
            
            S1.Text = "民夫：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["1"]);
            S2.Text = "义兵：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["2"]);
            S3.Text = "斥候：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["3"]);
            S4.Text = "长枪兵：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["4"]);
            S5.Text = "刀盾兵：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["5"]);
            S6.Text = "弓箭兵：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["6"]);
            S7.Text = "轻骑兵：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["7"]);
            S8.Text = "铁骑兵：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["8"]);
            S9.Text = "辎重车：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["9"]);
            S10.Text = "床弩：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["10"]);
            S11.Text = "冲车：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["11"]);
            S12.Text = "投石车：" + Convert.ToString(sg.LoginUser.UserCities[com.SelectedIndex].Army["12"]);

            r1.Text = "粮食：" + sg.LoginUser.UserCities[com.SelectedIndex].resources["food"];
            r2.Text = "木材：" + sg.LoginUser.UserCities[com.SelectedIndex].resources["wood"];
            r3.Text = "石料：" + sg.LoginUser.UserCities[com.SelectedIndex].resources["rock"];
            r4.Text = "铁锭：" + sg.LoginUser.UserCities[com.SelectedIndex].resources["iron"];
            r5.Text = "黄金：" + sg.LoginUser.UserCities[com.SelectedIndex].resources["gold"];

            Heroscom.SelectedIndex = 0;
            if (sg.LoginUser.UserCities[com.SelectedIndex].Heros != null)
                for(int i=0;i<sg.LoginUser.UserCities[com.SelectedIndex].Heros.Length;i++)
                    if ((string)sg.LoginUser.UserCities[com.SelectedIndex].Heros[i]["state"] == "0")
                        Heroscom.Items.Add(sg.LoginUser.UserCities[com.SelectedIndex].Heros[i]["name"]);

            selectCity = true;
            mResource.Clear();
            for (int i = 0; i < 5; i++)
                mResource.Add(i, 0);
            mRestTime = Convert.ToInt64(Rest_Hours.Value) * 3600 + Convert.ToInt64(Rest_Min.Value) * 60;
        }

        private void Army1_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army1.Value = 0;
                return;
            }
            if (this.Army1.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["1"]))
                this.Army1.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["1"]);
            tArmy.ArmyInfo["1"] = Convert.ToString(this.Army1.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army2_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army2.Value = 0;
                return;
            }
            if (this.Army2.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["2"]))
                this.Army2.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["2"]);
            tArmy.ArmyInfo["2"] = Convert.ToString(this.Army2.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army3_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army3.Value = 0;
                return;
            }
            if (this.Army3.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["3"]))
                this.Army3.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["3"]);
            tArmy.ArmyInfo["3"] = Convert.ToString(this.Army3.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army4_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army4.Value = 0;
                return;
            }
            if (this.Army4.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["4"]))
                this.Army4.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["4"]);
            tArmy.ArmyInfo["4"] = Convert.ToString(this.Army4.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army5_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army5.Value = 0;
                return;
            }
            if (this.Army5.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["5"]))
                this.Army5.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["5"]);
            tArmy.ArmyInfo["5"] = Convert.ToString(this.Army5.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army6_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army6.Value = 0;
                return;
            }
            if (this.Army6.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["6"]))
                this.Army6.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["6"]);
            tArmy.ArmyInfo["6"] = Convert.ToString(this.Army6.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army7_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army7.Value = 0;
                return;
            }
            if (this.Army7.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["7"]))
                this.Army7.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["7"]);
            tArmy.ArmyInfo["7"] = Convert.ToString(this.Army7.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army8_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army8.Value = 0;
                return;
            }
            if (this.Army8.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["8"]))
                this.Army8.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["8"]);
            tArmy.ArmyInfo["8"] = Convert.ToString(this.Army8.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army9_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army9.Value = 0;
                return;
            }
            if (this.Army9.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["9"]))
                this.Army9.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["9"]);
            tArmy.ArmyInfo["9"] = Convert.ToString(this.Army9.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army10_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army10.Value = 0;
                return;
            }
            if (this.Army10.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["10"]))
                this.Army10.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["10"]);
            tArmy.ArmyInfo["10"] = Convert.ToString(this.Army10.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army11_Leave(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army11.Value = 0;
                return;
            }
            if (this.Army11.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["11"]))
                this.Army11.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["11"]);
            tArmy.ArmyInfo["11"] = Convert.ToString(this.Army11.Value);
            ArmyIsNull();           
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Army12_ValueChanged(object sender, EventArgs e)
        {
            if (!selectCity)
            {
                Army12.Value = 0;
                return;
            }
            if (this.Army12.Value > Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["12"]))
                this.Army12.Value = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Army["12"]);
            tArmy.ArmyInfo["12"] = Convert.ToString(this.Army12.Value);
            ArmyIsNull();            
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }

        private void Res5_Leave(object sender, EventArgs e)
        {
            if (this.Res0.Value > Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["gold"]))
                this.Res0.Value = Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["gold"]);
            mResource[0] = Convert.ToDouble(this.Res0.Value);
        }
        private void Res1_Leave(object sender, EventArgs e)
        {
            if (this.Res1.Value > Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["food"]))
                this.Res0.Value = Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["food"]);
            mResource[1] = Convert.ToDouble(this.Res1.Value);
        }
        private void Res2_Leave(object sender, EventArgs e)
        {
            if (this.Res2.Value > Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["wood"]))
                this.Res2.Value = Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["wood"]);
            mResource[2] = Convert.ToDouble(this.Res2.Value);
        }
        private void Res3_Leave(object sender, EventArgs e)
        {
            if (this.Res3.Value > Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["rock"]))
                this.Res3.Value = Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["rock"]);
            mResource[3] = Convert.ToDouble(this.Res3.Value);
        }
        private void Res4_Leave(object sender, EventArgs e)
        {
            if (this.Res4.Value > Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["iron"]))
                this.Res4.Value = Convert.ToDecimal(sg.LoginUser.UserCities[com.SelectedIndex].resources["iron"]);
            mResource[4] = Convert.ToDouble(this.Res4.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool mArmyCount = false;
            foreach (var value in tArmy.ArmyInfo.Values)
            {
                if (Convert.ToInt32(value) > 0)
                    mArmyCount = true;
            }
            if (Heroscom.SelectedIndex == 0)
            {
                if (troopcom.SelectedIndex == 3 || troopcom.SelectedIndex == 4)
                {
                    MessageBox.Show("必须选择将领才能占领或掠夺！","出征错误");
                    return;
                }
            }
            if (Flag.Checked)
                if (MessageBox.Show("确定你使用军旗？", "军旗的使用", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    Flag.Checked = false;
                    return;
                }
            if (!mArmyCount)
            {
                MessageBox.Show("必须选择士兵！", "出征错误");
                return;
            }
            int TargetCity = Convert.ToInt32(Target_Y.Value) * 1000 + Convert.ToInt32(Target_X.Value);
            
            if (totalCarry - UseFood - Convert.ToInt64(Res0.Value) - Convert.ToInt64(Res1.Value) - Convert.ToInt64(Res2.Value) - Convert.ToInt64(Res3.Value) - Convert.ToInt64(Res4.Value) < 0)
            {
                MessageBox.Show("你的军队载重不足，无法带上这么多资源。", "出征错误");
                return;
            }

            if (chuzh.Checked)
            { 
                count = count + 1;
                tmpList = sg.GetTroopParam(troopcom.SelectedIndex, sg.LoginUser.UserCities[com.SelectedIndex], TargetCity, Heroid, tArmy, mRestTime, Flag.Checked, Convert.ToInt64(Res0.Value), Convert.ToInt64(Res1.Value), Convert.ToInt64(Res2.Value), Convert.ToInt64(Res3.Value), Convert.ToInt64(Res4.Value));
                int interval = Convert.ToInt32(Circle.Value * 60000);
                
                TimerList.Add(count, tmpList);                
               
                tmpTimer = new System.Threading.Timer(new TimerCallback(Timer_Tick),TimerList[count], 0, interval);

                TimerTable.Add(count, tmpTimer);

                string[] tmpInfo = new string[8];
                tmpInfo[0] = com.Text;
                tmpInfo[1] = Heroscom.Text;
                tmpInfo[2] = "(" + Convert.ToString(Target_X.Value) + "," + Convert.ToString(Target_Y.Value) + ")";
                tmpInfo[3] = "";
                tmpInfo[4] = "";
                tmpInfo[5] = troopcom.Text;
                tmpInfo[6] = Convert.ToString(Circle.Value);
                tmpInfo[7] = Convert.ToString(count);
                chuzh_Grid.Rows.Add(tmpInfo);                
            }
            else
            {
                sg.Troop(troopcom.SelectedIndex, sg.LoginUser.UserCities[com.SelectedIndex], TargetCity, Heroid, tArmy, mRestTime, Flag.Checked, Convert.ToInt64(Res0.Value), Convert.ToInt64(Res1.Value), Convert.ToInt64(Res2.Value), Convert.ToInt64(Res3.Value), Convert.ToInt64(Res4.Value));
                chuz_Box.AppendText(sg.str + "\r\n");
            }
        }

        void ArmyIsNull( )
        {
            int SoldierId = 1;
            bool ArmyisNull = true;
            for (int i = 0; i <= 11; i++)
                if (Convert.ToInt32(tArmy.ArmyInfo[Convert.ToString(sg.sortArmy[i])]) != 0)
                {
                    SoldierId = sg.sortArmy[i];
                    ArmyisNull = false;
                    break;
                }
            if (ArmyisNull)
                pathtime.Text = "单程时间：00:00:00";
            else
            {
                Sanguo.ArmyInfo tmpSoldier=sg.Soldier1;
                switch (SoldierId)
                {
                    case 1:
                        tmpSoldier = sg.Soldier1;
                        break;
                    case 2:
                        tmpSoldier = sg.Soldier2;
                        break;
                    case 3:
                        tmpSoldier = sg.Soldier3;
                        break;
                    case 4:
                        tmpSoldier = sg.Soldier4;
                        break;
                    case 5:
                        tmpSoldier = sg.Soldier5;
                        break;
                    case 6:
                        tmpSoldier = sg.Soldier6;
                        break;
                    case 7:
                        tmpSoldier = sg.Soldier7;
                        break;
                    case 8:
                        tmpSoldier = sg.Soldier8;
                        break;
                    case 9:
                        tmpSoldier = sg.Soldier9;
                        break;
                    case 10:
                        tmpSoldier = sg.Soldier10;
                        break;
                    case 11:
                        tmpSoldier = sg.Soldier11;
                        break;
                    case 12:
                        tmpSoldier = sg.Soldier12;
                        break;
                }
                mPathTime = sg.EvalMarchTime(troopcom.SelectedIndex, Sourcesite, Targetsite, MarchLevel, ReinLevel, HeroSpeedAddOn, DakLevel, tmpSoldier);
                pathtime.Text = "单程时间：" + Convert.ToString(mPathTime+mRestTime);               
            }
        }

        private void Rest_Hours_ValueChanged(object sender, EventArgs e)
        {
            mRestTime = Convert.ToInt64(Rest_Hours.Value) * 3600 + Convert.ToInt64(Rest_Min.Value) * 60;
            pathtime.Text = "单程时间：" + Convert.ToString(mPathTime+mRestTime);

            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Rest_Min_ValueChanged(object sender, EventArgs e)
        {
            mRestTime = Convert.ToInt64(Rest_Hours.Value) * 3600 + Convert.ToInt64(Rest_Min.Value) * 60;
            pathtime.Text = "单程时间：" + Convert.ToString(mPathTime+mRestTime);
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Target_X_ValueChanged(object sender, EventArgs e)
        {
            if (!selectCity)   
                return;
            Targetsite = Sanguo.Cid2Point(Convert.ToInt32(Target_Y.Value) * 1000 + Convert.ToInt32(Target_X.Value));
            ArmyIsNull();
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }
        private void Target_Y_ValueChanged(object sender, EventArgs e)
        {
            if (!selectCity)
                return;
            Targetsite = Sanguo.Cid2Point(Convert.ToInt32(Target_Y.Value) * 1000 + Convert.ToInt32(Target_X.Value));
            ArmyIsNull();
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }

        private void troopcom_TextChanged(object sender, EventArgs e)
        {
            if (!selectCity)
                return;
            ArmyIsNull();
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }

        private void Heroscom_TextChanged(object sender, EventArgs e)
        {
            if (!selectCity)
                return;
            if (Heroscom.SelectedIndex > 0)
            {
                for (int i = 0; i < sg.LoginUser.UserCities[com.SelectedIndex].Heros.Length; i++)
                    if ((string)sg.LoginUser.UserCities[com.SelectedIndex].Heros[i]["state"] == "0" && (string)sg.LoginUser.UserCities[com.SelectedIndex].Heros[i]["name"] == Heroscom.Text)
                    {
                        Heroid = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Heros[i]["heroid"]);
                        HeroSpeedAddOn = Convert.ToInt32(sg.LoginUser.UserCities[com.SelectedIndex].Heros[i]["speed"]);
                        break;
                    }                
            }
            else
            {
                Heroid = 0;
                HeroSpeedAddOn = 0;
            }
            ArmyIsNull();
            UseFood = sg.TroopFoodUse(tArmy, mPathTime + mRestTime);
            totalCarry = sg.TroopCarry(tArmy, CarryLevel);
            fooduse.Text = "出征耗粮：" + Convert.ToString(UseFood);
            food_rest.Text = "剩余空间：" + Convert.ToString(totalCarry - UseFood);
        }

        private void Timer_Tick(object sender)
        {
            sg.str = "没有出征";
            List<object> t1 = (sender as List<object>);

            sg.Troop(t1);
            if (sg.str.IndexOf("出征成功") < 0)
                this.BeginInvoke(new chuzhen(chuzhGrid));

            this.BeginInvoke(new chuzhen(chuzhInfo));
        }

        public delegate void chuzhen();
        void chuzhInfo()
        {
            chuz_Box.AppendText(sg.str + "\r\n");
        }
        void chuzhGrid()
        {
            int tmpRowCount = chuzh_Grid.Rows.Count;
            chuzh_Grid.Rows.Remove(chuzh_Grid.Rows[tmpRowCount - 1]);
            TimerList.Remove(tmpRowCount);
            TimerTable[tmpRowCount].Dispose();
            TimerTable.Remove(tmpRowCount);
            count--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chuzh_Grid.Rows.Count < 1)
                return;
            int tmpRow = chuzh_Grid.Rows.IndexOf(chuzh_Grid.CurrentRow);
            int tmpcount = Convert.ToInt32(chuzh_Grid.Rows[tmpRow].Cells[7].Value);
            chuzh_Grid.Rows.Remove(chuzh_Grid.CurrentRow);
            TimerList.Remove(tmpcount);
            TimerTable[tmpcount].Change(-1, -1);
            TimerTable[tmpcount].Dispose();
            TimerTable.Remove(tmpcount);
            count--;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Sanguo.TroopInfo[] tmpTroop = sg.GetArmyTroops();
            CityCom.Items.Clear();
            for (int i = 0; i < sg.LoginUser.UserCities.Length; i++)
            {
                sg.LoginUser.UserCities[i].TroopArmyCount = 0;
                CityCom.Items.Add(sg.LoginUser.UserCities[i].name);
            }            
            if(tmpTroop!=null)
                for (int i = 0; i < tmpTroop.Length; i++)
                {
                    sg.LoginUser.UserCities[Convert.ToInt32(sg.LoginUser.CitySort[Convert.ToString(tmpTroop[i].cid)])].TroopArmyCount++;
                }
            
            tmpTroop = sg.GetStayTroops();
            if (tmpTroop != null)
                for (int i = 0; i < tmpTroop.Length; i++)
                    sg.LoginUser.UserCities[Convert.ToInt32(sg.LoginUser.CitySort[Convert.ToString(tmpTroop[i].cid)])].TroopArmyCount++;
            dateTimeP.Value = DateTime.Now.AddHours(1);
        }

        private void CityCom_TextChanged(object sender, EventArgs e)
        {
            FoodArmyGrid.Rows.Clear();
            int tmpIndex = CityCom.SelectedIndex;
            Point T1 = Sanguo.Cid2Point(Convert.ToInt32(sg.LoginUser.UserCities[tmpIndex].cityid));

            long food_add = Convert.ToInt64(sg.LoginUser.UserCities[CityCom.SelectedIndex].resources["food_add"]);
            long food_army_use = Convert.ToInt64(sg.LoginUser.UserCities[CityCom.SelectedIndex].resources["food_army_use"]);
            long food_use = food_add - food_army_use;
            foodshchan.Text = Convert.ToString(food_use);
            if (food_use < 0)
            {
                carryfood.Text = Convert.ToString(Math.Ceiling(Math.Abs(food_use) * (zhengafter.Value + zhenbefore.Value) / 3600));
            }
            else
                carryfood.Text = "0";
            string[] tmpInfo = new string[8];
            long[] carrySpeed = new long[sg.LoginUser.UserCities.Length - 1];
            row = new int[sg.LoginUser.UserCities.Length - 1];            
            int k = 0;
            Dictionary<int, long> tmpDict = new Dictionary<int, long>();
            for (int i = 0; i < sg.LoginUser.UserCities.Length; i++)
            {               
                if (i != tmpIndex)
                {
                    int level = 0;
                    foreach (var tmpB in sg.LoginUser.UserCities[i].Builders.Values)
                    {
                        if ((tmpB as Sanguo.BuildInfo).BuildID == 8)
                        {
                            level = (tmpB as Sanguo.BuildInfo).level;
                            break;
                        }
                    }
                    int tmpDakLevel = 0;
                    foreach (var tmpBuild in sg.LoginUser.UserCities[i].Builders.Values)
                    {
                        if ((tmpBuild as Sanguo.BuildInfo).BuildID == 18)
                        {
                            tmpDakLevel = (tmpBuild as Sanguo.BuildInfo).level;
                            break;
                        }
                    }
                    Point S1 = Sanguo.Cid2Point(Convert.ToInt32(sg.LoginUser.UserCities[i].cityid));
                    int RLevel = 0;
                    if (sg.LoginUser.UserCities[i].Technology.ContainsKey("13"))
                        RLevel = Convert.ToInt32(sg.LoginUser.UserCities[i].Technology["13"]);
                    long tmpPathTime = sg.EvalMarchTime(TroopType.SelectedIndex, S1, T1, 0, RLevel, 0, tmpDakLevel, sg.Soldier9);
                    DateTime now = DateTime.Now;
                    DateTime end = now.AddSeconds(tmpPathTime);
                    string tmptme = Convert.ToString(end - now);
                    double zzcsl = Math.Ceiling(Convert.ToInt64(carryfood.Text) / (5000 * (1 + Convert.ToInt32(sg.LoginUser.UserCities[CityCom.SelectedIndex].Technology["16"]) * 0.1)));
                    
                    tmpInfo[0] = sg.LoginUser.UserCities[i].name;
                    tmpInfo[1] = Convert.ToString(sg.LoginUser.UserCities[i].resources["food"]);
                    tmpInfo[2] = Convert.ToString(level - sg.LoginUser.UserCities[i].TroopArmyCount);
                    tmpInfo[3] = "0";
                    tmpInfo[4] = Convert.ToString(sg.LoginUser.UserCities[i].Army["9"]);
                    tmpInfo[5] = Convert.ToString(zzcsl);
                    tmpInfo[6] = Convert.ToString(tmptme);
                    tmpInfo[7] = Convert.ToString(i);
                    FoodArmyGrid.Rows.Add(tmpInfo);
                    carrySpeed[k] = tmpPathTime;
                    tmpDict.Add(k, tmpPathTime);
                    k++;
                }                
            }
            Sanguo.fastsort(carrySpeed, 0, carrySpeed.Length - 1);
            for (int i = 0; i < carrySpeed.Length; i++)
            {
                foreach (var item in tmpDict)
                    if (item.Value == carrySpeed[i])
                        row[i] = item.Key;
            }
            ListSortDirection sortDirection = ListSortDirection.Ascending;
            FoodArmyGrid.Sort(Column7, sortDirection);
        }

        private void chuzhBtn_Click(object sender, EventArgs e)
        {          
            if (CityCom.Text == "")
            {
                MessageBox.Show("请选择养兵城池");
                return;
            }
            DateTime ArriveTime = DateTime.Parse(dateTimeP.Text);
            ArriveTime = ArriveTime.AddSeconds(-Convert.ToInt32(zhenbefore.Value));
            long timeoffSet = Convert.ToInt64(sg.GetServerTime(sg.LoginUser.UserCities[CityCom.SelectedIndex].cityid).ReslutValue);

            string tmptime = "";
            long timeoff = 0;
            int Cityzzcsl = 0;
            int carrycount = 0;
            int carryzzcsl = Convert.ToInt32(FoodArmyGrid.Rows[0].Cells[5].Value);
            Sanguo.CampaignArmy tmpArmy = new Sanguo.CampaignArmy();
            tmpArmy.init();

            for (int i = 0; i < row.Length; i++)
            {
                if (Convert.ToInt32(FoodArmyGrid.Rows[i].Cells[3].Value) == 0)
                    continue;
                if (Convert.ToInt32(FoodArmyGrid.Rows[i].Cells[3].Value) > Convert.ToInt32(FoodArmyGrid.Rows[i].Cells[2].Value))
                    FoodArmyGrid.Rows[i].Cells[3].Value = FoodArmyGrid.Rows[i].Cells[2].Value;

                sg.str = "";

                tmptime = (string)FoodArmyGrid.Rows[i].Cells[6].Value;
                string[] t = tmptime.Split(':');
                long t1 = Convert.ToInt32(t[0]) * 3600 + Convert.ToInt32(t[1]) * 60 + Convert.ToInt32(t[2]);
                timeoff = Convert.ToInt64(Sanguo.ConvertDateTimeInt(ArriveTime.AddSeconds(carrycount * 3600)) - Sanguo.ConvertDateTimeInt(DateTime.Now.AddSeconds(t1 + timeoffSet)));
                if (timeoff < 0)
                {
                    MessageBox.Show("不能在指定的时间把粮食运输到指定的城池");
                    return;
                }

                Cityzzcsl = Convert.ToInt32(FoodArmyGrid.Rows[i].Cells[4].Value);
                long CityFood_rest = Convert.ToInt32(FoodArmyGrid.Rows[i].Cells[1].Value);
                int pXiabiao = Convert.ToInt32(FoodArmyGrid.Rows[i].Cells[7].Value);
                int pClevel = Convert.ToInt32(sg.LoginUser.UserCities[pXiabiao].Technology["16"]);
                for (int j = 1; j <= Convert.ToInt32(FoodArmyGrid.Rows[i].Cells[3].Value); j++)
                {
                    if (CityFood_rest < Convert.ToInt32(carryfood.Text))
                        break;

                    timeoff = Convert.ToInt64(Sanguo.ConvertDateTimeInt(ArriveTime.AddSeconds(carrycount * 3600)) - Sanguo.ConvertDateTimeInt(DateTime.Now.AddSeconds(t1 + timeoffSet)));
                    while (sg.TroopCarry(carryzzcsl, pClevel) - sg.TroopFoodUse(carryzzcsl, t1 + timeoff) < Convert.ToInt64(carryfood.Text))
                        carryzzcsl++;
                    if (Cityzzcsl < carryzzcsl)
                        break;
                    tmpArmy.ArmyInfo["9"] = Convert.ToString(carryzzcsl);

                    sg.Troop(TroopType.SelectedIndex, sg.LoginUser.UserCities[pXiabiao], sg.LoginUser.UserCities[CityCom.SelectedIndex].cityid, 0,
                        tmpArmy, timeoff, false, 0, Convert.ToDouble(carryfood.Text), 0, 0, 0);

                    if (sg.str.IndexOf("出征成功") > -1)
                    {
                        carrycount++;
                        Cityzzcsl = Cityzzcsl - carryzzcsl;
                        CityFood_rest = CityFood_rest - Convert.ToInt64(carryfood.Text);
                        Mess.AppendText(sg.str + "\r\n");
                    }
                    Thread.Sleep(1000);
                }
            }
        }

        private void RefreshBtn2_Click(object sender, EventArgs e)
        {            
            zhanlGridRefresh();
            chuzhBtn2.Enabled = true;
        }

        private void SolderType_SelectedValueChanged(object sender, EventArgs e)
        {
            zhanlGridRefresh();
        }

        void zhanlGridRefresh()
        {
            zhanlGrid.Rows.Clear();
            Sanguo.TroopInfo[] tmpTroop = sg.GetArmyTroops();
            for (int i = 0; i < sg.LoginUser.UserCities.Length; i++)
                sg.LoginUser.UserCities[i].TroopArmyCount = 0;
            if (tmpTroop != null)
                for (int i = 0; i < tmpTroop.Length; i++)
                    sg.LoginUser.UserCities[Convert.ToInt32(sg.LoginUser.CitySort[Convert.ToString(tmpTroop[i].cid)])].TroopArmyCount++;
            tmpTroop = sg.GetStayTroops();
            if (tmpTroop != null)
                for (int i = 0; i < tmpTroop.Length; i++)
                    sg.LoginUser.UserCities[Convert.ToInt32(sg.LoginUser.CitySort[Convert.ToString(tmpTroop[i].cid)])].TroopArmyCount++;
            dateTimeP2.Value = DateTime.Now.AddHours(1);            
            Point T1 = Sanguo.Cid2Point(Convert.ToInt32(zhanlY.Value) * 1000 + Convert.ToInt32(zhanlX.Value));
            string[] tmpInfo = new string[7];
            long[] carrySpeed = new long[sg.LoginUser.UserCities.Length];
            zhanl_row = new int[sg.LoginUser.UserCities.Length];
            Dictionary<int, long> tmpDict = new Dictionary<int, long>();
            for (int i = 0; i < sg.LoginUser.UserCities.Length; i++)
            {
                int level = 0;
                foreach (var tmpB in sg.LoginUser.UserCities[i].Builders.Values)
                {
                    if ((tmpB as Sanguo.BuildInfo).BuildID == 8)
                    {
                        level = (tmpB as Sanguo.BuildInfo).level;
                        break;
                    }
                }
                int tmpHerosCount = 0;
                if (sg.LoginUser.UserCities[i].Heros!=null)
                    for (int j = 0; j < sg.LoginUser.UserCities[i].Heros.Length; j++)
                        if ((string)sg.LoginUser.UserCities[i].Heros[j]["state"] == "0")
                            tmpHerosCount++;                
                int tmpMarchLevel = 0, tmpReinLevel = 0;
                if (sg.LoginUser.UserCities[i].Technology.ContainsKey("12"))
                    tmpMarchLevel = Convert.ToInt32(sg.LoginUser.UserCities[i].Technology["12"]); //as TechInfo).Level : 0
                if (sg.LoginUser.UserCities[i].Technology.ContainsKey("13"))
                    tmpReinLevel = Convert.ToInt32(sg.LoginUser.UserCities[i].Technology["13"]);
                Point S1 = Sanguo.Cid2Point(Convert.ToInt32(sg.LoginUser.UserCities[i].cityid));
                long tmpPathTime = 0;
                if (SolderType.SelectedIndex == 1)
                    tmpPathTime = sg.EvalMarchTime(4, S1, T1, tmpMarchLevel, tmpReinLevel, 0, 0, sg.Soldier9);
                else
                    tmpPathTime = sg.EvalMarchTime(4, S1, T1, tmpMarchLevel, tmpReinLevel, 0, 0, sg.Soldier7);
                DateTime now = DateTime.Now;
                DateTime end = now.AddSeconds(tmpPathTime);
                string tmptme = Convert.ToString(end - now);

                tmpInfo[0] = sg.LoginUser.UserCities[i].name;
                tmpInfo[1] = Convert.ToString(tmpHerosCount);
                if (level - sg.LoginUser.UserCities[i].TroopArmyCount >= tmpHerosCount)
                    tmpInfo[2] = Convert.ToString(tmpHerosCount);
                else
                    tmpInfo[2] = Convert.ToString(level - sg.LoginUser.UserCities[i].TroopArmyCount);
                tmpInfo[3] = "0";
                tmpInfo[4] = Convert.ToString(sg.LoginUser.UserCities[i].Army["9"]);
                tmpInfo[5] = Convert.ToString(tmptme);
                tmpInfo[6] = Convert.ToString(sg.LoginUser.UserCities[i].resources["food"]);
                //tmpInfo[7] = Convert.ToString(i);
                zhanlGrid.Rows.Add(tmpInfo);

                carrySpeed[i] = tmpPathTime;
                tmpDict.Add(i, tmpPathTime);
            }

            Sanguo.fastsort(carrySpeed, 0, carrySpeed.Length - 1);
            for (int i = 0; i < carrySpeed.Length; i++)
            {
                foreach (var item in tmpDict)
                    if (item.Value == carrySpeed[i])
                        zhanl_row[i] = item.Key;
            }

            ListSortDirection sortDirection = ListSortDirection.Ascending;
            zhanlGrid.Sort(Column14, sortDirection);        
        }

        private void zhanlX_Leave(object sender, EventArgs e)
        {
            zhanlGrid.Rows.Clear();
            chuzhBtn2.Enabled = false;
        }

        private void zhanlY_Leave(object sender, EventArgs e)
        {
            zhanlGrid.Rows.Clear();
            chuzhBtn2.Enabled = false;
        }

        private void CityInfoBtn_Click(object sender, EventArgs e)
        {
            for(int i=0;i<sg.LoginUser.UserCities.Length;i++)
                sg.GetCityInfo(sg.LoginUser.UserCities[i].cityid);
        }

        private void chuzhBtn2_Click(object sender, EventArgs e)
        {            
            DateTime ArriveTime = DateTime.Parse(dateTimeP2.Text);
            ArriveTime = ArriveTime.AddSeconds(-Convert.ToInt32(zhengdianq.Value));
            long timeoffSet = Convert.ToInt64(sg.GetServerTime(sg.LoginUser.UserCities[0].cityid).ReslutValue);
            string tmptime = ""; 
            long timeoff = 0;
            int carrycount = 0;
            Dictionary<int, int> tmpHeros = new Dictionary<int, int>();
            int T1 = Convert.ToInt32(zhanlY.Value) * 1000 + Convert.ToInt32(zhanlX.Value);
            Sanguo.CampaignArmy tmpArmy=new Sanguo.CampaignArmy();
            tmpArmy.init();

            if (IsForever.Checked)
            {
                for (int i = 0; i < zhanl_row.Length; i++)
                {
                    if (Convert.ToInt32(zhanlGrid.Rows[i].Cells[3].Value) == 0)
                        continue;
                    if (Convert.ToInt32(zhanlGrid.Rows[i].Cells[3].Value) > Convert.ToInt32(zhanlGrid.Rows[i].Cells[2].Value))
                        zhanlGrid.Rows[i].Cells[3].Value = zhanlGrid.Rows[i].Cells[2].Value;
                                        
                    int tmpHerosCount = 0;
                    for (int k = 0; k < sg.LoginUser.UserCities[zhanl_row[i]].Heros.Length; k++)
                        if ((string)sg.LoginUser.UserCities[zhanl_row[i]].Heros[k]["state"] == "0")
                        {
                            tmpHeros.Add(tmpHerosCount + 1, Convert.ToInt32(sg.LoginUser.UserCities[zhanl_row[i]].Heros[k]["heroid"]));
                            tmpHerosCount++;
                        }
                    for (int j = 1; j <= Convert.ToInt32(zhanlGrid.Rows[i].Cells[3].Value); j++)
                    {
                        sg.str = "";                        
                        tmpArmy.ArmyInfo["7"] = Convert.ToString(1);

                        sg.Troop(4, sg.LoginUser.UserCities[zhanl_row[i]], T1, tmpHeros[j], tmpArmy, 0, false, 0, 0, 0, 0, 0);

                        if (sg.str.IndexOf("出征成功") > -1)
                            carrycount++;
                        Mess1.AppendText(sg.str + "\r\n");
                        Thread.Sleep(1000);
                    }
                    tmpHeros.Clear();
                }
                return;
            }

            for (int i = 0; i < zhanl_row.Length; i++)
            {
                if (Convert.ToInt32(zhanlGrid.Rows[i].Cells[3].Value) == 0)
                    continue;
                if (Convert.ToInt32(zhanlGrid.Rows[i].Cells[3].Value) > Convert.ToInt32(zhanlGrid.Rows[i].Cells[2].Value))
                    zhanlGrid.Rows[i].Cells[3].Value = zhanlGrid.Rows[i].Cells[2].Value;

                tmptime = (string)zhanlGrid.Rows[i].Cells[5].Value;
                
                long t1 = 0;
                if (tmptime.IndexOf(".") > -1)
                {
                    t1 = Convert.ToInt64(tmptime.Substring(0, tmptime.IndexOf(".") - 1)) * 3600 * 24;
                    tmptime = tmptime.Substring(tmptime.IndexOf(".") + 1);
                    string[] t = tmptime.Split(':');
                    t1=t1+Convert.ToInt32(t[0]) * 3600 + Convert.ToInt32(t[1]) * 60 + Convert.ToInt32(t[2]);
                }
                else
                {
                    string[] t = tmptime.Split(':');
                    t1 = Convert.ToInt32(t[0]) * 3600 + Convert.ToInt32(t[1]) * 60 + Convert.ToInt32(t[2]);
                }
                
                timeoff = Convert.ToInt64(Sanguo.ConvertDateTimeInt(ArriveTime.AddSeconds(carrycount * 3600)) - Sanguo.ConvertDateTimeInt(DateTime.Now.AddSeconds(t1 + timeoffSet)));
                if (timeoff < 0)
                {
                    MessageBox.Show("不能在指定的时间到达指定的城池");
                    return;
                }

                int tmpHerosCount = 0;                
                for (int k = 0; k < sg.LoginUser.UserCities[zhanl_row[i]].Heros.Length; k++)
                    if ((string)sg.LoginUser.UserCities[zhanl_row[i]].Heros[k]["state"] == "0")
                    {
                        tmpHeros.Add(tmpHerosCount + 1, Convert.ToInt32(sg.LoginUser.UserCities[zhanl_row[i]].Heros[k]["heroid"]));
                        tmpHerosCount++;
                    }
                
                for (int j = 1; j <= Convert.ToInt32(zhanlGrid.Rows[i].Cells[3].Value); j++)
                {
                    sg.str = "";
                    timeoff = Convert.ToInt64(Sanguo.ConvertDateTimeInt(ArriveTime.AddSeconds(carrycount * 3600)) - Sanguo.ConvertDateTimeInt(DateTime.Now.AddSeconds(t1 + timeoffSet)));

                    if (SolderType.SelectedIndex == 1)
                        tmpArmy.ArmyInfo["9"] = Convert.ToString(1);
                    else
                        tmpArmy.ArmyInfo["7"] = Convert.ToString(1);

                    sg.Troop(4, sg.LoginUser.UserCities[zhanl_row[i]], T1, tmpHeros[j], tmpArmy, timeoff, false, 0, 0, 0, 0, 0);

                    if (sg.str.IndexOf("出征成功") > -1)
                        carrycount++;
                    Mess1.AppendText(sg.str + "\r\n");

                    Thread.Sleep(1000);
                }
                tmpHeros.Clear();
            }
        }

        private void IsForever_CheckedChanged(object sender, EventArgs e)
        {
            if (IsForever.Checked)
                SolderType.Enabled = false;
            else
                SolderType.Enabled = true;
        }

        private void RefreshBtn3_Click(object sender, EventArgs e)
        {
            GrowTree.Nodes.Clear();

            for (int i = 0; i < sg.LoginUser.UserCities.Length; i++)
            {
                TreeNode tmpNode = new TreeNode(sg.LoginUser.UserCities[i].name + "（" + sg.LoginUser.UserCities[i].Builders.Count.ToString() + "建筑）");
                GrowTree.Nodes.Add(tmpNode);
                bool IsGrow = false;
                foreach (var item in sg.LoginUser.UserCities[i].Builders.Values)
                {
                    Sanguo.BuildInfo tmpBuildInfo = (item as Sanguo.BuildInfo);
                    GrowTree.Nodes[i].Nodes.Add(tmpBuildInfo.bname + tmpBuildInfo.level.ToString() + "级");
                    if (tmpBuildInfo.level < 9)
                        IsGrow = true;
                }
                if (IsGrow)
                    GrowTree.Nodes[i].BackColor = Color.Red;
            }
        }

        private void GrowTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
                foreach(TreeNode node in e.Node.Nodes)
                    node.Checked = true;
            else
                foreach (TreeNode node in e.Node.Nodes)
                    node.Checked = false;
        }

        private void GrowBtn_Click(object sender, EventArgs e)
        {            
            string[] tmpstr = new string[8];
            for (int i = 0; i < GrowTree.Nodes.Count; i++)
            {
                bool IsParentOwn = false;
                foreach (var tmpKey in GrowTable.Keys)
                    if (tmpKey == i)
                        IsParentOwn = true;
                if (IsParentOwn == false)
                {
                    List<object[]> tmpGrowList = new List<object[]>();
                    for (int j = 0; j < GrowTree.Nodes[i].Nodes.Count; j++)
                        if (GrowTree.Nodes[i].Nodes[j].Checked)
                        {
                            int TargetLevel = Convert.ToInt32(GrowLevel.Value);
                            Sanguo.BuildInfo tmpBuild = (sg.LoginUser.UserCities[i].Builders[j.ToString()] as Sanguo.BuildInfo);
                            if (tmpBuild.level >= TargetLevel)
                                continue;
                            tmpstr[0] = sg.LoginUser.UserCities[i].name;
                            tmpstr[1] = sg.LoginUser.UserCities[i].cityid.ToString();
                            tmpstr[2] = tmpBuild.bname;
                            tmpstr[3] = Convert.ToString(tmpBuild.id);
                            tmpstr[4] = Convert.ToString(tmpBuild.level);
                            tmpstr[5] = Convert.ToString(GrowLevel.Value);
                            tmpstr[6] = Convert.ToString(i);
                            tmpstr[7] = Convert.ToString(j);
                            GrowGrid.Rows.Add(tmpstr);
                            object[] tmpObjcet = new object[] { j, tmpstr[2], tmpstr[3], tmpBuild.level, TargetLevel, true };
                            tmpGrowList.Add(tmpObjcet);
                        }
                    if (tmpGrowList.Count > 0)
                        GrowTable.Add(i, tmpGrowList);
                }
                else                
                    for (int j = 0; j < GrowTree.Nodes[i].Nodes.Count; j++)
                    {
                        bool IsChildOwn = false;
                        if (GrowTree.Nodes[i].Nodes[j].Checked)
                        {
                            for(int k=0;k<GrowTable[i].Count;k++)
                                if (j == Convert.ToInt32(GrowTable[i][k][0]))
                                {
                                    IsChildOwn = true;
                                    break;
                                }                            
                            if(IsChildOwn)
                                continue;
                            int TargetLevel = Convert.ToInt32(GrowLevel.Value);
                            Sanguo.BuildInfo tmpBuild = (sg.LoginUser.UserCities[i].Builders[j.ToString()] as Sanguo.BuildInfo);
                            if (tmpBuild.level >= TargetLevel)
                                continue;
                            tmpstr[0] = sg.LoginUser.UserCities[i].name;
                            tmpstr[1] = sg.LoginUser.UserCities[i].cityid.ToString();
                            tmpstr[2] = tmpBuild.bname;
                            tmpstr[3] = Convert.ToString(tmpBuild.id);
                            tmpstr[4] = Convert.ToString(tmpBuild.level);
                            tmpstr[5] = Convert.ToString(GrowLevel.Value);
                            tmpstr[6] = Convert.ToString(i);
                            tmpstr[7] = Convert.ToString(j);
                            GrowGrid.Rows.Add(tmpstr);
                            object[] tmpObjcet = new object[] { j, tmpstr[2], tmpstr[3], tmpBuild.level, TargetLevel, true };
                            GrowTable[i].Add(tmpObjcet);
                        }
                    }                
            }
        }

        private void GrowStartBtn_Click(object sender, EventArgs e)
        {
            if (GrowGrid.Rows.Count < 1)
            {
                MessageBox.Show("请选择要升级的建筑物！");
                return;
            }            
            foreach (var tmpDict in GrowTable.Keys)
            {
                bool IsGrow = true;
                for (int j = 0; j < GrowCityBuildList.Count; j++)
                    if (GrowCityBuildList[j] == tmpDict)
                    {
                        IsGrow = false;
                        break;
                    }
                if (IsGrow == false)
                    continue;
                GrowCityBuildList.Add(tmpDict);
                AsyncEventHandler growBld = new AsyncEventHandler(GrowBuild);
                growBld.BeginInvoke(tmpDict, null, null);
                Thread.Sleep(500);
            }  
        }

        public delegate void AsyncEventHandler(int DictKey); 
       
        void GrowBuild(int DictKey)
        {
            int pCityId = sg.LoginUser.UserCities[DictKey].cityid;            
            List<long> tmpTimeList = new List<long>();
            int i = 0;
            bool IsGrowth = true;
            while (i < (GrowTable[DictKey] as List<object[]>).Count)
            {
                object[] tmpObject = sg.GetCityBuilding(pCityId);                
                string tmpBuildType = Convert.ToString((GrowTable[DictKey] as List<object[]>)[i][1]);
                Sanguo.BuildInfo tmpBuilding = sg.LoginUser.UserCities[DictKey].Builders[Convert.ToString((GrowTable[DictKey] as List<object[]>)[i][0])] as Sanguo.BuildInfo;
                for (int j = 0; j < tmpObject.Length; j++)
                    if (tmpBuilding.XY == Convert.ToInt32((tmpObject[j] as FluorineFx.ASObject)["xy"]))
                    {
                        (sg.LoginUser.UserCities[DictKey].Builders[Convert.ToString((GrowTable[DictKey] as List<object[]>)[i][0])] as Sanguo.BuildInfo).state = Convert.ToInt32((tmpObject[j] as FluorineFx.ASObject)["state"]);
                        (GrowTable[DictKey] as List<object[]>)[i][3] = Convert.ToInt32((tmpObject[j] as FluorineFx.ASObject)["level"]);
                        if ((GrowTable[DictKey] as List<object[]>)[i][3] == (GrowTable[DictKey] as List<object[]>)[i][4])
                            (GrowTable[DictKey] as List<object[]>)[i][5] = false;
                    }
                    else
                        continue;
                for (int j = 0; j < (GrowTable[DictKey] as List<object[]>).Count; j++)
                {
                    if (Convert.ToBoolean((GrowTable[DictKey] as List<object[]>)[i][5]))
                        break;
                    IsGrowth = false;                    
                }
                if (IsGrowth == false)
                {
                    string end = "升级建筑结束！";
                    this.Invoke(new showInfo(GrowInfo), end);
                    break;
                }
                if (Convert.ToBoolean((GrowTable[DictKey] as List<object[]>)[i][5]) == false)
                {
                    i++;
                    if (i == (GrowTable[DictKey] as List<object[]>).Count)
                    {
                        Thread.Sleep(10000);
                        i = 0;
                    }
                    continue;
                }
                if ((sg.LoginUser.UserCities[DictKey].Builders[Convert.ToString((GrowTable[DictKey] as List<object[]>)[i][0])] as Sanguo.BuildInfo).state == 1)
                {
                    i++;
                    if (i == (GrowTable[DictKey] as List<object[]>).Count)
                    {
                        Thread.Sleep(1000);
                        i = 0;
                    }
                    continue;                    
                }
                int IsInnerOrOut = 1;
                if (tmpBuildType.Equals("农田") || tmpBuildType.Equals("伐木场") || tmpBuildType.Equals("采石场") || tmpBuildType.Equals("铁矿"))
                    IsInnerOrOut = 0;
                string GrowMessage = "";
                Object[] tmpOb = sg.GetBuildingInfo(pCityId, tmpBuilding, IsInnerOrOut);
                bool IsResourceNeed = true;
                for (int j = 0; j < tmpOb.Length; j++)
                {
                    if (Convert.ToInt64(sg.LoginUser.UserCities[DictKey].resources["food"]) - Convert.ToInt64(tmpOb[0]) < 0)
                        IsResourceNeed = false;
                    if (Convert.ToInt64(sg.LoginUser.UserCities[DictKey].resources["wood"]) - Convert.ToInt64(tmpOb[1]) < 0)
                        IsResourceNeed = false;
                    if (Convert.ToInt64(sg.LoginUser.UserCities[DictKey].resources["rock"]) - Convert.ToInt64(tmpOb[2]) < 0)
                        IsResourceNeed = false;
                    if (Convert.ToInt64(sg.LoginUser.UserCities[DictKey].resources["iron"]) - Convert.ToInt64(tmpOb[3]) < 0)
                        IsResourceNeed = false;
                }
                
                string tmpstr = "";
                if (IsResourceNeed == false)
                {
                    GrowMessage = "升级建筑失败，失败原因：资源不足";
                    tmpstr = Convert.ToString(DateTime.Now) + " " + sg.LoginUser.UserCities[DictKey].name + (GrowTable[DictKey] as List<object[]>)[i][1] + (GrowTable[DictKey] as List<object[]>)[i][2] + GrowMessage + "\r\n";
                    this.Invoke(new showInfo(GrowInfo), tmpstr);
                    i++;
                    if (i == (GrowTable[DictKey] as List<object[]>).Count)
                    {
                        Thread.Sleep(10000);
                        i = 0;
                    }
                    continue;
                }                
                GrowMessage = sg.StartUpgradeBuilding(tmpBuilding, pCityId, IsInnerOrOut);
                tmpstr = Convert.ToString(DateTime.Now) + " " + sg.LoginUser.UserCities[DictKey].name + (GrowTable[DictKey] as List<object[]>)[i][1] + (GrowTable[DictKey] as List<object[]>)[i][2] + GrowMessage + "\r\n";
                this.Invoke(new showInfo(GrowInfo), tmpstr);
                if (GrowMessage.Equals("升级成功！"))
                {
                    tmpTimeList.Add(Convert.ToInt64(tmpOb[4]));
                    i++;
                    if (i == (GrowTable[DictKey] as List<object[]>).Count)
                        i = 0;

                }
                else
                {                    
                    if (tmpTimeList.Count == 0)
                    {              
                        object[] tmpObje = sg.GetCityBuilding(sg.LoginUser.UserCities[DictKey].cityid);
                        for (int j = 0; j < tmpObje.Length; j++)
                            if (Convert.ToInt32((tmpObje[j] as FluorineFx.ASObject)["state"]) == 1)
                                tmpTimeList.Add(Convert.ToInt64((tmpObje[j] as FluorineFx.ASObject)["state_timeleft"]));
                            else
                                continue;                        
                    }

                    long restTime = tmpTimeList.Min();
                    tmpTimeList.Remove(restTime);
                    for (int j = 0; j < tmpTimeList.Count; j++)
                    {
                        tmpTimeList[j] = tmpTimeList[j] - restTime;
                        if (tmpTimeList[j] == 0)
                            tmpTimeList.Remove(0);
                    }
                    Thread.Sleep(Convert.ToInt32(restTime + 1) * 1000);
                }
                Thread.Sleep(800);
            }            
        }
        
        public delegate void showInfo(string growInfo);

        void GrowInfo(string Info)
        {
            Mess2.AppendText(Info);
        }

        private void sgForm_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(@"C:\rxsg\html"))            
                System.IO.Directory.CreateDirectory(@"C:\rxsg\html");
            if (File.Exists(@"C:\rxsg\html\app1.html") && File.Exists(@"C:\rxsg\html\app.swf"))
                return;
            String sourcePath = System.Windows.Forms.Application.StartupPath + "\\html";
            String targetPath = "c:\\rxsg\\html";

            string[] files = Directory.GetFiles(sourcePath);
            if (files.Length > 0)
                foreach (string s in files)
                    File.Copy(s, targetPath + s.Substring(s.LastIndexOf("\\")));
        }

        public void CopyFiles(string varFromDirectory, string varToDirectory)//实现从一个目录下完整拷贝到另一个目录下。 
        {
            Directory.CreateDirectory(varToDirectory);            
            string[] directories = Directory.GetDirectories(varFromDirectory);//取文件夹下所有文件夹名，放入数组； 
            if (directories.Length > 0)
                foreach (string d in directories)
                {
                    CopyFiles(d, varToDirectory + d.Substring(d.LastIndexOf("\\")));//递归拷贝文件和文件夹 
                }
            string[] files = Directory.GetFiles(varFromDirectory);//取文件夹下所有文件名，放入数组； 
            if (files.Length > 0)
                foreach (string s in files)
                    File.Copy(s, varToDirectory + s.Substring(s.LastIndexOf("\\")));
        }

        private void zhenbefore_ValueChanged(object sender, EventArgs e)
        {
            long food_add = Convert.ToInt64(sg.LoginUser.UserCities[CityCom.SelectedIndex].resources["food_add"]);
            long food_army_use = Convert.ToInt64(sg.LoginUser.UserCities[CityCom.SelectedIndex].resources["food_army_use"]);
            long food_use = food_add - food_army_use;
            foodshchan.Text = Convert.ToString(food_use);
            if (food_use < 0)
            {
                carryfood.Text = Convert.ToString(Math.Ceiling(Math.Abs(food_use) * (zhengafter.Value + zhenbefore.Value) / 3600));
            }
            else
                carryfood.Text = "0";
        }

        private void zhengafter_ValueChanged(object sender, EventArgs e)
        {
            long food_add = Convert.ToInt64(sg.LoginUser.UserCities[CityCom.SelectedIndex].resources["food_add"]);
            long food_army_use = Convert.ToInt64(sg.LoginUser.UserCities[CityCom.SelectedIndex].resources["food_army_use"]);
            long food_use = food_add - food_army_use;
            foodshchan.Text = Convert.ToString(food_use);
            if (food_use < 0)
            {
                carryfood.Text = Convert.ToString(Math.Ceiling(Math.Abs(food_use) * (zhengafter.Value + zhenbefore.Value) / 3600));
            }
            else
                carryfood.Text = "0";
        }
    }    
}
