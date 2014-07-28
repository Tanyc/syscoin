namespace TCPClientEx203
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
            this.rchTxtBoxReceive = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxState = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.rchTxtBoxSend = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchTxtBoxReceive
            // 
            this.rchTxtBoxReceive.Location = new System.Drawing.Point(103, 146);
            this.rchTxtBoxReceive.Name = "rchTxtBoxReceive";
            this.rchTxtBoxReceive.Size = new System.Drawing.Size(289, 86);
            this.rchTxtBoxReceive.TabIndex = 24;
            this.rchTxtBoxReceive.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxState);
            this.groupBox1.Location = new System.Drawing.Point(207, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 127);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "程序状态";
            // 
            // lstBoxState
            // 
            this.lstBoxState.FormattingEnabled = true;
            this.lstBoxState.ItemHeight = 12;
            this.lstBoxState.Location = new System.Drawing.Point(12, 16);
            this.lstBoxState.Name = "lstBoxState";
            this.lstBoxState.Size = new System.Drawing.Size(162, 100);
            this.lstBoxState.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(315, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "关闭连接";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(180, 353);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(33, 354);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 20;
            this.btnRequest.Text = "请求连接";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // rchTxtBoxSend
            // 
            this.rchTxtBoxSend.Location = new System.Drawing.Point(103, 242);
            this.rchTxtBoxSend.Name = "rchTxtBoxSend";
            this.rchTxtBoxSend.Size = new System.Drawing.Size(287, 95);
            this.rchTxtBoxSend.TabIndex = 19;
            this.rchTxtBoxSend.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "发送信息：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "接受信息：";
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Location = new System.Drawing.Point(101, 67);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(100, 21);
            this.txtBoxPort.TabIndex = 16;
            this.txtBoxPort.Text = "6888";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "请求端口：";
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Location = new System.Drawing.Point(101, 25);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.Size = new System.Drawing.Size(100, 21);
            this.txtBoxIP.TabIndex = 14;
            this.txtBoxIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "服务器IP：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 386);
            this.Controls.Add(this.rchTxtBoxReceive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.rchTxtBoxSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "客户端程序";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBoxReceive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBoxState;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.RichTextBox rchTxtBoxSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxIP;
        private System.Windows.Forms.Label label1;
    }
}

