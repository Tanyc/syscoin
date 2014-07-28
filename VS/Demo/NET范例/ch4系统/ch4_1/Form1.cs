using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Diagnostics;

namespace ch4_1
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
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
			UpdateProcess();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
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

		private void UpdateProcess()
		{
		//代表进程名
		string processName;
		//代表进程号
		int processID;
		//线程数
		int threadNumber;
		//cpu时间
		TimeSpan cpuTime;
		//占用的物理内存
		int memory;
		//优先级
		int priorityNumber;
		//启动时间
		DateTime startTime;

		//获取当前系统中的所有进程
		Process[] processes= Process.GetProcesses();

		//清除列表视图中原有的内容
		if (this.listView1!=null)
		{
			this.listView1.Items.Clear();
		}

		//在列表中加入每个进程项目的详细信息
		for(int i = 0; i < processes.Length; i++)
		{
				processName=processes[i].ProcessName;
				processID=processes[i].Id;
				threadNumber=processes[i].Threads.Count;
				cpuTime=processes[i].TotalProcessorTime;
				memory=processes[i].WorkingSet;
			 	priorityNumber=processes[i].BasePriority;
				startTime=processes[i].StartTime;
				string prior="";
            //判断优先级的值
			if (priorityNumber==13){prior="高";};
			if (priorityNumber==4){prior="低";};
			if (priorityNumber==8){prior="标准";};
			if (priorityNumber==24){prior="实时";};
            //进程信息
			string[] subItems={
								processName,
								processID.ToString(),
								threadNumber.ToString(),
								String.Format("{0:00}:{1:00}:{2:00}",
									cpuTime.Hours, cpuTime.Minutes, cpuTime.Seconds),
								String.Format("{0:#,#,#}K", memory / 1024),
								prior,
								startTime.ToLongTimeString()
								};
			//构造一项并插入
			ListViewItem item=new ListViewItem(subItems);
			this.listView1.Items.Insert(i,item);
	   	}		
	    }

		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.panel1 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.listView1});
			this.panel1.Location = new System.Drawing.Point(16, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 240);
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
																						this.columnHeader7});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(328, 240);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "进程名";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PID";
			this.columnHeader2.Width = 42;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "线程数";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "cpu占用时间";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "占用内存";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "优先级";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "启动时间";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 24);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "新建进程";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(128, 24);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "结束进程";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(224, 24);
			this.button3.Name = "button3";
			this.button3.TabIndex = 3;
			this.button3.Text = "刷新列表";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button2,
																					this.button3,
																					this.button1});
			this.groupBox1.Location = new System.Drawing.Point(16, 272);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 64);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "进程管理";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 349);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.panel1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "系统进程管理";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
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
			//构造打开文件对话框
			OpenFileDialog ofDlg = new OpenFileDialog();
			//选择可执行文件
			ofDlg.Filter = "可执行文件 (*.exe)|*.exe|所有文件(*.*)|*.*";
			//显示对话框
			if(ofDlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					//启动选择的程序
					Process newProcess = Process.Start(ofDlg.FileName);
					newProcess.EnableRaisingEvents=true;
					//为它添加退出进程的事件代理
					newProcess.Exited += new EventHandler(OnProcessExited);
					//更新列表
					UpdateProcess();
	
				}
					//参数错误异常
				catch(ArgumentException aError)
				{
					MessageBox.Show("出现错误："+aError.Message, "警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		private void OnProcessExited(object sender, EventArgs e)
		{			
			//刷新ListView控件
			UpdateProcess();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
		    
			//刷新ListView控件
			UpdateProcess();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(this.listView1.SelectedItems.Count>0)
			{
				//获取选中项目中的ID值
				int processID = Int32.Parse(listView1.SelectedItems[0].SubItems[1].Text);
				//根据ID获取进程
				Process selectedProcess = Process.GetProcessById(processID);
                selectedProcess.EnableRaisingEvents=true;
				//为它添加退出进程的事件代理
				selectedProcess.Exited += new EventHandler(OnProcessExited);

				//如果进程还没有退出
				if(!selectedProcess.HasExited)
				{
					//如果关闭主窗口失败
					if(!selectedProcess.CloseMainWindow())
					{
						//提示是否要杀死进程
						if(MessageBox.Show("不能关闭应用程序窗口，需要继续终止进程吗？",
							"提示",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							try
							{
								//杀死进程
								selectedProcess.Kill();
								//更新列表
								UpdateProcess();

							}
							catch(Exception excep)
							{
								MessageBox.Show(excep.Message, "不能结束进程", MessageBoxButtons.OK,MessageBoxIcon.Error);
							}
						}
					}
				}
				else
				{
					MessageBox.Show("选中的进程已经退出！", "提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
					UpdateProcess();
				}
			}
			else
			{
				MessageBox.Show("请先选中一个当前正在运行的进程！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
	
	}
}
