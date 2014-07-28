namespace AsyncTcpServerEx204
{
    partial class FrmServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstBoxStatu = new System.Windows.Forms.ListBox();
            this.txtBoxMessag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.btnSendMes = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(58, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(209, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "结束监听";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lstBoxStatu
            // 
            this.lstBoxStatu.FormattingEnabled = true;
            this.lstBoxStatu.ItemHeight = 12;
            this.lstBoxStatu.Location = new System.Drawing.Point(24, 50);
            this.lstBoxStatu.Name = "lstBoxStatu";
            this.lstBoxStatu.Size = new System.Drawing.Size(424, 232);
            this.lstBoxStatu.TabIndex = 2;
            // 
            // txtBoxMessag
            // 
            this.txtBoxMessag.Location = new System.Drawing.Point(24, 288);
            this.txtBoxMessag.Multiline = true;
            this.txtBoxMessag.Name = "txtBoxMessag";
            this.txtBoxMessag.Size = new System.Drawing.Size(424, 79);
            this.txtBoxMessag.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择客户";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(100, 386);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(184, 20);
            this.comboBoxClient.TabIndex = 5;
            // 
            // btnSendMes
            // 
            this.btnSendMes.Location = new System.Drawing.Point(373, 383);
            this.btnSendMes.Name = "btnSendMes";
            this.btnSendMes.Size = new System.Drawing.Size(75, 23);
            this.btnSendMes.TabIndex = 6;
            this.btnSendMes.Text = "发送信息";
            this.btnSendMes.UseVisualStyleBackColor = true;
            this.btnSendMes.Click += new System.EventHandler(this.btnSendMes_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(359, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 430);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSendMes);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMessag);
            this.Controls.Add(this.lstBoxStatu);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmServer";
            this.Text = "异步服务器";
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lstBoxStatu;
        private System.Windows.Forms.TextBox txtBoxMessag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Button btnSendMes;
        private System.Windows.Forms.Button btnClear;
    }
}

