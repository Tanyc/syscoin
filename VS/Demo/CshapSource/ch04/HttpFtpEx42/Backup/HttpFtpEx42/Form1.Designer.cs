namespace HttpFtpEx42
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRecUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLocalFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxThreadCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(25, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 292);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "接受文件的Url";
            // 
            // txtBoxRecUrl
            // 
            this.txtBoxRecUrl.Location = new System.Drawing.Point(360, 29);
            this.txtBoxRecUrl.Name = "txtBoxRecUrl";
            this.txtBoxRecUrl.Size = new System.Drawing.Size(193, 21);
            this.txtBoxRecUrl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "本地文件名";
            // 
            // txtBoxLocalFile
            // 
            this.txtBoxLocalFile.Location = new System.Drawing.Point(362, 83);
            this.txtBoxLocalFile.Name = "txtBoxLocalFile";
            this.txtBoxLocalFile.Size = new System.Drawing.Size(191, 21);
            this.txtBoxLocalFile.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "接收的线程数";
            // 
            // txtBoxThreadCount
            // 
            this.txtBoxThreadCount.Location = new System.Drawing.Point(363, 133);
            this.txtBoxThreadCount.Name = "txtBoxThreadCount";
            this.txtBoxThreadCount.Size = new System.Drawing.Size(190, 21);
            this.txtBoxThreadCount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "接收起止时间";
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(364, 183);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(189, 21);
            this.txtBoxTime.TabIndex = 8;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(373, 246);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 9;
            this.btnReceive.Text = "开始接收";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 327);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxThreadCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxLocalFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxRecUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "HTTP协议多线程文件传输程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRecUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLocalFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxThreadCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.Button btnReceive;
        public System.Windows.Forms.ListBox listBox1;
    }
}

