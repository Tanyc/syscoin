namespace IPEx201
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
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnRemote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(10, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 208);
            this.listBox1.TabIndex = 0;
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 238);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLocal.TabIndex = 1;
            this.btnLocal.Text = "显示本机IP信息";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnRemote
            // 
            this.btnRemote.Location = new System.Drawing.Point(201, 238);
            this.btnRemote.Name = "btnRemote";
            this.btnRemote.Size = new System.Drawing.Size(75, 23);
            this.btnRemote.TabIndex = 2;
            this.btnRemote.Text = "显示服务器信息";
            this.btnRemote.UseVisualStyleBackColor = true;
            this.btnRemote.Click += new System.EventHandler(this.btnRemote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnRemote);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "IP类使用例子";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnRemote;
    }
}

