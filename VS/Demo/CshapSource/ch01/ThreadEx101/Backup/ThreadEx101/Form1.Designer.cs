﻿namespace ThreadEx101
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
            this.lstTest = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 12;
            this.lstTest.Location = new System.Drawing.Point(15, 25);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(174, 232);
            this.lstTest.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(205, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(205, 170);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 2;
            this.btnLook.Text = "查看";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstTest);
            this.Name = "Form1";
            this.Text = "单线程程序";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLook;
    }
}

