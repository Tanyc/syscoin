using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Diagnostics;

namespace ch4_6
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.ComponentModel.IContainer components;

		private EventLogEntryCollection  eventCollection;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			LoadEventLog();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void LoadEventLog()
		{
		    //构造一个日志对象
			EventLog  systemEvent=new EventLog();
			//说明这个日志是系统日志
			systemEvent.Log="System";
			//获得系统日志的记录集合
		    eventCollection=systemEvent.Entries;

			//记录的长度
			int length=eventCollection.Count;
			for (int i=0;i<length;i++)
			{
				EventLogEntry entry=eventCollection[length-i-1];
			    //构造一个ListViewItem的子项
				string[] subItems={
								      //类型
									  entry.EntryType.ToString(),
									  //日期
									  entry.TimeGenerated.ToLongDateString(),
									  //时间
				                      entry.TimeGenerated.ToLongTimeString(),
									  //来源
									  entry.Source,
									  //分类
									  entry.Category,
									  //事件
									  entry.EventID.ToString(),
									  //用户
				                      entry.UserName,
									  //计算机名
									  entry.MachineName
								  };

				ListViewItem  item=new ListViewItem(subItems);
				//添加记录
				this.listView1.Items.Add(item);			
			}
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.button1 = new System.Windows.Forms.Button();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.listView1});
			this.panel1.Location = new System.Drawing.Point(24, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 296);
			this.panel1.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3,
																						this.columnHeader4,
																						this.columnHeader5,
																						this.columnHeader6,
																						this.columnHeader7,
																						this.columnHeader8});
			this.listView1.ContextMenu = this.contextMenu1;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(432, 296);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "类型";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "日期";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "时间";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "来源";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "分类";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "事件";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "用户";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "计算机";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(384, 336);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "更新日志";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "事件详细信息";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(480, 389);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.panel1});
			this.Name = "Form1";
			this.Text = "系统日志查看";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
            //请空记录
			this.listView1.Items.Clear();		  
			//更新日志
			LoadEventLog();

		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
	     //获取指定记录在listView中的索引
		 int i=this.listView1.SelectedItems[0].Index;
		 //获取记录的总数目
         int length=this.eventCollection.Count;
		 //获取指定记录的消息
		 string message=eventCollection[length-i-1].Message;
		 //弹出消息框
         MessageBox.Show("这条日志的详细信息是： "+message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);

		}
	}
}
