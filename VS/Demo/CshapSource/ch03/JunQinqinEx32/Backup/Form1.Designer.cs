﻿namespace JunQinqinEx32
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_remoteport;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox qi_pan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            try//5-04
            {
                ReadFlag = false;
                if (udpclient != null) udpclient.Close();
                if (th != null) th.Abort();
                th = null;
            }
            catch { } 

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_remoteport = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.qi_pan = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.qi_pan)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(563, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 32);
            this.button6.TabIndex = 38;
            this.button6.Text = "结束退出";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(457, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "label2";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(555, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 24);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.Text = "从机";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(459, 135);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 32);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "主机";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(457, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(563, 311);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(80, 32);
            this.btnAgain.TabIndex = 33;
            this.btnAgain.Text = "重新开始";
            this.btnAgain.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(563, 263);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 32);
            this.btnConnect.TabIndex = 32;
            this.btnConnect.Text = "联  机";
            this.btnConnect.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(467, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "对方端口";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(467, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "本地端口";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(467, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "对方IP";
            // 
            // txt_remoteport
            // 
            this.txt_remoteport.Location = new System.Drawing.Point(539, 103);
            this.txt_remoteport.Name = "txt_remoteport";
            this.txt_remoteport.Size = new System.Drawing.Size(120, 21);
            this.txt_remoteport.TabIndex = 28;
            this.txt_remoteport.Text = "4444";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(539, 63);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(120, 21);
            this.txt_port.TabIndex = 27;
            this.txt_port.Text = "3333";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(539, 23);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(120, 21);
            this.txt_IP.TabIndex = 26;
            this.txt_IP.Text = "127.0.0.1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(314, 409);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 24);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "开始对战";
            this.btnStart.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(314, 361);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(64, 24);
            this.btnRead.TabIndex = 24;
            this.btnRead.Text = "读取布阵";
            this.btnRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 24);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "保存布阵";
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // qi_pan
            // 
            this.qi_pan.Image = ((System.Drawing.Image)(resources.GetObject("qi_pan.Image")));
            this.qi_pan.Location = new System.Drawing.Point(2, 1);
            this.qi_pan.Name = "qi_pan";
            this.qi_pan.Size = new System.Drawing.Size(447, 446);
            this.qi_pan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.qi_pan.TabIndex = 22;
            this.qi_pan.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel1.Text = "欢迎网络对战军棋";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 478);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_remoteport);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.qi_pan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "二人网络对战军棋";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.qi_pan)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


    }
}

