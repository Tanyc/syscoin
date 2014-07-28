namespace ThreadEx102
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(200, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 12;
            this.lstTest.Location = new System.Drawing.Point(12, 12);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(173, 220);
            this.lstTest.TabIndex = 1;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(200, 175);
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
            this.ClientSize = new System.Drawing.Size(281, 246);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "多线程例子";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.Button btnLook;
    }
}