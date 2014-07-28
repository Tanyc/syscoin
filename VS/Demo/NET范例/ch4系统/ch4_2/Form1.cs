using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Diagnostics;

namespace ch4_2
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			DisplayModuals();
			DisplayMemory();
	
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}
			
		private void DisplayModuals()
		{
		
			Process[] ch42;
			ProcessModuleCollection modules;
			//通过进程名获取进程
			ch42 = Process.GetProcessesByName("ch4_2");
			// 获得模块集合
			modules = ch42[0].Modules;
			// 将库名加入listBox1中
			foreach (ProcessModule aModule in modules)
			{
				this.listBox1.Items.Add(aModule.ModuleName);
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(24, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(240, 112);
			this.listBox1.Sorted = true;
			this.listBox1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.listBox1});
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 160);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "进程加载的库";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.listView1});
			this.groupBox2.Location = new System.Drawing.Point(16, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 208);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "进程内存使用详细信息";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2});
			this.listView1.Location = new System.Drawing.Point(24, 32);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(240, 160);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "内存使用类别";
			this.columnHeader1.Width = 123;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "大小";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 421);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "进程详细信息";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		private void DisplayMemory()
		{
			Process[] ch42;
			ProcessModuleCollection modules;
			ch42 = Process.GetProcessesByName("ch4_2");

			//获取专用内存大小
			int privateMemory=ch42[0].PrivateMemorySize;
			string[] subitems={"专用内存",(privateMemory/1024).ToString()+" K"};
			ListViewItem item=new ListViewItem(subitems);
			this.listView1.Items.Add(item);
             
			//获取峰值虚拟内存大小
			int peakVirtualMemorySize=ch42[0].PeakVirtualMemorySize;
			string[] subitems1={"最大虚拟内存",(peakVirtualMemorySize/1024).ToString()+" K"};
			ListViewItem item1=new ListViewItem(subitems1);
			this.listView1.Items.Add(item1);
		
			//获取峰值分页内存大小
			int peakPagedMemorySize=ch42[0].PeakPagedMemorySize;
			string[] subitems2={"最大分页内存大小",(peakPagedMemorySize/1024).ToString()+" K"};
			ListViewItem item2=new ListViewItem(subitems2);
			this.listView1.Items.Add(item2);

			//获取分页的系统内存大小
			int pagedSystemMemorySize=ch42[0].PagedSystemMemorySize;
			string[] subitems3={"分页的系统内存大小",(pagedSystemMemorySize/1024).ToString()+" K"};
			ListViewItem item3=new ListViewItem(subitems3);
			this.listView1.Items.Add(item3);

			//获取分页的内存大小
			int pagedMemorySize=ch42[0].PagedMemorySize;
			string[] subitems4={"分页的内存大小",(pagedMemorySize/1024).ToString()+" K"};
			ListViewItem item4=new ListViewItem(subitems4);
			this.listView1.Items.Add(item4);
		
			//获取未分页的系统内存大小。
			int nonpagedSystemMemorySize=ch42[0].NonpagedSystemMemorySize;
			string[] subitems5={"未分页的系统内存大小",(nonpagedSystemMemorySize/1024).ToString()+" K"};
			ListViewItem item5=new ListViewItem(subitems5);
			this.listView1.Items.Add(item5);

			//获取物理内存使用情况
			int  memorySize=ch42[0].WorkingSet;
			string[] subitems6={"物理内存大小",(memorySize/1024).ToString()+" K"};
			ListViewItem item6=new ListViewItem(subitems6);
			this.listView1.Items.Add(item6);

			//获取进程的虚拟内存大小
			int  virtualMemorySize=ch42[0].VirtualMemorySize;
			string[] subitems7={"虚拟内存大小",(virtualMemorySize/1024).ToString()+" K"};
			ListViewItem item7=new ListViewItem(subitems7);
			this.listView1.Items.Add(item7);
		}
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
      
	    
         }
	
	}
