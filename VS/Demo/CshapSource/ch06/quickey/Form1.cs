using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;//以下为新添加的命名空间
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace quickey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KeyboardHook hook = new KeyboardHook();
        private const string config = "config.dat";
        bool isHookEnable = true;
        private const int KEY_QUOTLEFT = 219;//键盘上 [ 键的代码
        private const int KEY_QUOTRIGHT = 221;//键盘上 ] 键的代码

        private const uint WM_SETTEXT = 0x000C;
        private const uint WM_CHAR = 0x0102;
        private const uint EM_SETSEL = 0x00B1;

        private const int WM_CLOSE = 0x10;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        private ComboBox CreateCombo(string key)
        {
            ComboBox com = new ComboBox();
            com.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 48; i <= 57; i++)//数字
            {
                ComboItem item = new ComboItem(((Keys)i).ToString(), i.ToString());
                com.Items.Add(item);
            }
            for (int num = 96; num <= 105; num++)//小键盘数字
            {
                ComboItem item = new ComboItem(((Keys)num).ToString(), num.ToString());
                com.Items.Add(item);
            }
            for (int alp = 65; alp <= 90; alp++) //字母
            {
                ComboItem item = new ComboItem(((Keys)alp).ToString(), alp.ToString());
                com.Items.Add(item);
            }
            for (int f = 112; f <= 123; f++)//F1~F12
            {
                ComboItem item = new ComboItem(((Keys)f).ToString(), f.ToString());
                com.Items.Add(item);
            }
            com.Items.Add(new ComboItem(((Keys)32).ToString(), "32"));//空格
            if (!string.IsNullOrEmpty(key))
            {
                int k = int.Parse(key);
                ComboItem selectItem = new ComboItem(((Keys)k).ToString(), key);
                com.SelectedItem = selectItem;
            }
            return com;
        }
        int i = 0;
        private GroupBox CreateGroup()
        {
            return CreateGroup("", "");
        }
        private GroupBox CreateGroup(string key1, string key2)
        {
            i++;
            GroupBox gb = new GroupBox();
            gb.Size = new Size(340, 80);
            gb.Text = "改键" + i;

            ComboBox com1 = CreateCombo(key1);
            com1.Location = new Point(20, 20);
            gb.Controls.Add(com1);

            Label lb = new Label();
            lb.Text = "改为：";
            lb.AutoSize = false;
            lb.Size = new Size(50, 23);
            lb.Location = new Point(150, 25);
            gb.Controls.Add(lb);

            ComboBox com2 = CreateCombo(key2);
            com2.Location = new Point(200, 20);
            gb.Controls.Add(com2);

            Button btnRemove = new Button();
            btnRemove.Text = "移 除";
            btnRemove.Click += new EventHandler(btnRemove_Click);
            btnRemove.Location = new Point(240, 50);
            gb.Controls.Add(btnRemove);

            return gb;
        }

        void btnRemove_Click(object sender, EventArgs e)
        {
            i--;
            Button btn = sender as Button;
            flowLayoutPanel1.Controls.Remove(btn.Parent);
            int d = 0;
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is GroupBox)
                {
                    (c as GroupBox).Text = "改键" + (++d);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hook.OnKeyDownEvent += new KeyEventHandler(hook_OnKeyDownEvent);

            if (File.Exists(config))
            {
                try
                {
                    FileStream fs = new FileStream(config, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    hash = (Hashtable)bf.Deserialize(fs);
                    fs.Close();
                }
                catch { }
            }
            if (hash.Count > 0)
            {
                foreach (DictionaryEntry de in hash)
                {
                    flowLayoutPanel1.Controls.Add(CreateGroup(de.Value.ToString(), de.Key.ToString()));
                }
            }
            else
            {
                GroupBox gb1 = CreateGroup();
                flowLayoutPanel1.Controls.Add(gb1);
            }
            flowLayoutPanel1.Controls[0].Height -= 20;
            flowLayoutPanel1.Controls[0].Controls.RemoveAt(3);

            IntPtr hDeskTop = FindWindow("Progman", "Program Manager");
            SetParent(this.Handle, hDeskTop); //windows+D不会隐藏
        }

        void hook_OnKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Scroll)
            {
                isHookEnable = !isHookEnable;
                this.Text = isHookEnable ? "quickey-开启":"quickey-停用";
                notifyIcon1.Text = this.Text;
            }
            if (isHookEnable)
            {
                IntPtr war3 = FindWindow(null, "Warcraft III");
                if (war3 != IntPtr.Zero)
                {
                    SetForegroundWindow(war3);
                    if(checkBox1.Checked)
                        SendMessage(war3, WM_KEYDOWN, KEY_QUOTLEFT,0);//按下[,可显示友方单位生命值
                    if(checkBox2.Checked)
                        SendMessage(war3, WM_KEYDOWN, KEY_QUOTRIGHT, 0);//按下],可显示友方单位生命值
                    if (hash.ContainsKey(e.KeyValue.ToString()))
                    {
                        SendMessage(war3, WM_KEYDOWN, int.Parse(hash[e.KeyValue.ToString()].ToString()), 0);
                        SendMessage(war3, WM_KEYUP, int.Parse(hash[e.KeyValue.ToString()].ToString()), 0);
                    }
                }
            }
        }

        [DllImport("USER32.DLL")]
        public static extern IntPtr FindWindow(string lpClassName,string lpWindowName);
        [DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd,uint Msg, int wParam, int lParam);
        [DllImport("user32")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("User32.dll")]
        public static extern void keybd_event(Byte bVk, Byte bScan, Int32 dwFlags, Int32 dwExtraInfo);
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(CreateGroup());

        }

        Hashtable hash = new Hashtable();
        private void button2_Click(object sender, EventArgs e)
        {
            hash.Clear();
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is GroupBox)
                {
                    GroupBox gb1 = c as GroupBox;
                    ComboBox com1 = gb1.Controls[0] as ComboBox;
                    ComboBox com2 = gb1.Controls[2] as ComboBox;
                    if (com1.SelectedItem != null && com2.SelectedItem != null)
                    {
                        ComboItem item1 = (ComboItem)com1.SelectedItem;
                        ComboItem item2 = (ComboItem)com2.SelectedItem;
                        hash.Add(item2.value, item1.value);
                    }
                }
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            if (hash.Count > 0)
            {
                try
                {
                    FileStream fs = new FileStream(config, FileMode.OpenOrCreate);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, hash);
                    fs.Close();
                }
                catch {
                    MessageBox.Show("保存设置失败!","失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        //关闭或最小化时隐藏
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            const int SC_MINIMIZE = 0xF020;
            if (m.Msg == WM_SYSCOMMAND && ((int)m.WParam == SC_MINIMIZE || (int)m.WParam == SC_CLOSE))
            {
                //最小化到系统栏 
                this.Hide();
                return;
            }
            base.WndProc(ref m);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }

    public struct ComboItem
    {
        public string text;
        public string value;
        public ComboItem(string text, string value)
        {
            this.text = text;
            this.value = value;
        }

        public override string ToString()//重写此方法使ComboBox显示文本   
        {
            return this.text;
        }
    }
}
