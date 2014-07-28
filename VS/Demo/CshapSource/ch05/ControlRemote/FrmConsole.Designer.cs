namespace ControlRemote
{
    partial class FrmConsole
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        /// //Download by http://www.codefans.net
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsole));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索客户端RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程发送消息QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程一键恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程关机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程唤醒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.发送消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程重启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.远程关机ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.远程唤醒ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作OToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作OToolStripMenuItem
            // 
            this.操作OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.搜索客户端RToolStripMenuItem,
            this.远程发送消息QToolStripMenuItem,
            this.远程一键恢复ToolStripMenuItem,
            this.远程关机ToolStripMenuItem,
            this.远程唤醒ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.操作OToolStripMenuItem.Name = "操作OToolStripMenuItem";
            this.操作OToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.操作OToolStripMenuItem.Text = "操作(&O)";
            // 
            // 搜索客户端RToolStripMenuItem
            // 
            this.搜索客户端RToolStripMenuItem.Name = "搜索客户端RToolStripMenuItem";
            this.搜索客户端RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.搜索客户端RToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.搜索客户端RToolStripMenuItem.Text = "搜索客户端(&S)";
            this.搜索客户端RToolStripMenuItem.Click += new System.EventHandler(this.搜索客户端RToolStripMenuItem_Click);
            // 
            // 远程发送消息QToolStripMenuItem
            // 
            this.远程发送消息QToolStripMenuItem.Name = "远程发送消息QToolStripMenuItem";
            this.远程发送消息QToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.远程发送消息QToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.远程发送消息QToolStripMenuItem.Text = "远程发送消息(&Q)";
            this.远程发送消息QToolStripMenuItem.Click += new System.EventHandler(this.远程发送消息QToolStripMenuItem_Click);
            // 
            // 远程一键恢复ToolStripMenuItem
            // 
            this.远程一键恢复ToolStripMenuItem.Name = "远程一键恢复ToolStripMenuItem";
            this.远程一键恢复ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.远程一键恢复ToolStripMenuItem.Text = "远程一键恢复(&R)";
            // 
            // 远程关机ToolStripMenuItem
            // 
            this.远程关机ToolStripMenuItem.Name = "远程关机ToolStripMenuItem";
            this.远程关机ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.远程关机ToolStripMenuItem.Text = "远程关机(&C)";
            this.远程关机ToolStripMenuItem.Click += new System.EventHandler(this.远程关机ToolStripMenuItem_Click);
            // 
            // 远程唤醒ToolStripMenuItem
            // 
            this.远程唤醒ToolStripMenuItem.Name = "远程唤醒ToolStripMenuItem";
            this.远程唤醒ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.远程唤醒ToolStripMenuItem.Text = "远程唤醒";
            this.远程唤醒ToolStripMenuItem.Click += new System.EventHandler(this.远程唤醒ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送消息ToolStripMenuItem,
            this.远程注销ToolStripMenuItem,
            this.远程重启ToolStripMenuItem,
            this.远程关机ToolStripMenuItem1,
            this.远程唤醒ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 114);
            // 
            // 发送消息ToolStripMenuItem
            // 
            this.发送消息ToolStripMenuItem.Name = "发送消息ToolStripMenuItem";
            this.发送消息ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.发送消息ToolStripMenuItem.Text = "发送消息";
            this.发送消息ToolStripMenuItem.Click += new System.EventHandler(this.发送消息ToolStripMenuItem_Click);
            // 
            // 远程注销ToolStripMenuItem
            // 
            this.远程注销ToolStripMenuItem.Name = "远程注销ToolStripMenuItem";
            this.远程注销ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.远程注销ToolStripMenuItem.Text = "远程注销";
            this.远程注销ToolStripMenuItem.Click += new System.EventHandler(this.远程注销ToolStripMenuItem_Click);
            // 
            // 远程重启ToolStripMenuItem
            // 
            this.远程重启ToolStripMenuItem.Name = "远程重启ToolStripMenuItem";
            this.远程重启ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.远程重启ToolStripMenuItem.Text = "远程重启";
            this.远程重启ToolStripMenuItem.Click += new System.EventHandler(this.远程重启ToolStripMenuItem_Click);
            // 
            // 远程关机ToolStripMenuItem1
            // 
            this.远程关机ToolStripMenuItem1.Name = "远程关机ToolStripMenuItem1";
            this.远程关机ToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.远程关机ToolStripMenuItem1.Text = "远程关机";
            this.远程关机ToolStripMenuItem1.Click += new System.EventHandler(this.远程关机ToolStripMenuItem1_Click);
            // 
            // 远程唤醒ToolStripMenuItem1
            // 
            this.远程唤醒ToolStripMenuItem1.Name = "远程唤醒ToolStripMenuItem1";
            this.远程唤醒ToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.远程唤醒ToolStripMenuItem1.Text = "远程唤醒";
            this.远程唤醒ToolStripMenuItem1.Click += new System.EventHandler(this.远程唤醒ToolStripMenuItem1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(706, 482);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FrmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主控制端程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsole_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索客户端RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程关机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程一键恢复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程唤醒ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 远程注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程重启ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程关机ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 远程唤醒ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 发送消息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程发送消息QToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

