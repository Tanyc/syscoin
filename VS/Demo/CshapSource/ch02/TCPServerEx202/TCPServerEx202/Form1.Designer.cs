namespace TCPServerEx202
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
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
            this.label1 = new System.Windows.Forms.Label();
            this.ServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListePort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendMessage = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSendMes = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServerState = new System.Windows.Forms.ListBox();
            this.AcceptMess = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP：";
            // 
            // ServerIP
            // 
            this.ServerIP.Location = new System.Drawing.Point(90, 38);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(100, 21);
            this.ServerIP.TabIndex = 1;
            this.ServerIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "监听端口：";
            // 
            // ListePort
            // 
            this.ListePort.Location = new System.Drawing.Point(90, 80);
            this.ListePort.Name = "ListePort";
            this.ListePort.Size = new System.Drawing.Size(100, 21);
            this.ListePort.TabIndex = 3;
            this.ListePort.Text = "6888";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "接受信息：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "发送信息：";
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(92, 255);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(287, 95);
            this.SendMessage.TabIndex = 7;
            this.SendMessage.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 367);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSendMes
            // 
            this.btnSendMes.Location = new System.Drawing.Point(169, 366);
            this.btnSendMes.Name = "btnSendMes";
            this.btnSendMes.Size = new System.Drawing.Size(75, 23);
            this.btnSendMes.TabIndex = 9;
            this.btnSendMes.Text = "发送消息";
            this.btnSendMes.UseVisualStyleBackColor = true;
            this.btnSendMes.Click += new System.EventHandler(this.btnSendMes_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(304, 368);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "停止监听";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerState);
            this.groupBox1.Location = new System.Drawing.Point(196, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器状态";
            // 
            // ServerState
            // 
            this.ServerState.FormattingEnabled = true;
            this.ServerState.ItemHeight = 12;
            this.ServerState.Location = new System.Drawing.Point(12, 16);
            this.ServerState.Name = "ServerState";
            this.ServerState.Size = new System.Drawing.Size(162, 100);
            this.ServerState.TabIndex = 0;
            // 
            // AcceptMess
            // 
            this.AcceptMess.Location = new System.Drawing.Point(92, 159);
            this.AcceptMess.Name = "AcceptMess";
            this.AcceptMess.Size = new System.Drawing.Size(289, 86);
            this.AcceptMess.TabIndex = 12;
            this.AcceptMess.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 402);
            this.Controls.Add(this.AcceptMess);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSendMes);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListePort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TCP服务器";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ListePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox AcceptMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox SendMessage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSendMes;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ServerState;
        private System.Windows.Forms.RichTextBox AcceptMess;
    }
}

