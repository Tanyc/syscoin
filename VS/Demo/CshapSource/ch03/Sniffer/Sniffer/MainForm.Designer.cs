using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Sniffer
{
    partial class MainForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbIpList = new System.Windows.Forms.ComboBox();
            this.lvSniffInfo = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacketInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始捕获";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(140, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "结束捕获";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(251, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbIpList
            // 
            this.cmbIpList.FormattingEnabled = true;
            this.cmbIpList.Location = new System.Drawing.Point(383, 26);
            this.cmbIpList.Name = "cmbIpList";
            this.cmbIpList.Size = new System.Drawing.Size(184, 20);
            this.cmbIpList.TabIndex = 3;
            // 
            // lvSniffInfo
            // 
            this.lvSniffInfo.FullRowSelect = true;
            this.lvSniffInfo.GridLines = true;
            this.lvSniffInfo.Location = new System.Drawing.Point(24, 62);
            this.lvSniffInfo.Name = "lvSniffInfo";
            this.lvSniffInfo.Size = new System.Drawing.Size(543, 201);
            this.lvSniffInfo.TabIndex = 4;
            this.lvSniffInfo.UseCompatibleStateImageBehavior = false;
            this.lvSniffInfo.View = System.Windows.Forms.View.Details;
            this.lvSniffInfo.SelectedIndexChanged += new System.EventHandler(this.lvSniffInfo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "显示包的消息数据:";
            // 
            // txtPacketInfo
            // 
            this.txtPacketInfo.Location = new System.Drawing.Point(24, 304);
            this.txtPacketInfo.Multiline = true;
            this.txtPacketInfo.Name = "txtPacketInfo";
            this.txtPacketInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPacketInfo.Size = new System.Drawing.Size(543, 143);
            this.txtPacketInfo.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 474);
            this.Controls.Add(this.txtPacketInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSniffInfo);
            this.Controls.Add(this.cmbIpList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "网络数据包监控软件";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbIpList;
        private System.Windows.Forms.ListView lvSniffInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacketInfo;
        //private SniffSocket mySniffSocket;

        ///// <summary>
        ///// 事件处理方法
        ///// </summary>
        ///// <param name="sender">引发事件对象</param>
        ///// <param name="e">事件参数</param>
        //private void DataArrival(object sender, SniffSocket.PacketArrivedEventArgs e)
        //{

        //    String str = "";
        //    foreach (byte b in e.MessageBuffer)//处理数据包中的消息(十六进制显示)
        //    {
        //        str += b.ToString("x") + "\t";
        //    }

        //    String[] data = new String[] {e.Protocol.ToString(),
        //        e.OriginationAddress.ToString(),
        //        e.DestinationAddress.ToString(),
        //        e.OriginationPort.ToString(),
        //        e.DestinationPort.ToString(),
        //        e.Date.ToString(),
        //        str};

        //    lvSniffInfo.Items.Add(new ListViewItem(data));//将基本信息添加到列表框中

        //}
    }
}