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
	/// Form1 ��ժҪ˵����
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
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			UpdateProcess();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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
		//���������
		string processName;
		//������̺�
		int processID;
		//�߳���
		int threadNumber;
		//cpuʱ��
		TimeSpan cpuTime;
		//ռ�õ������ڴ�
		int memory;
		//���ȼ�
		int priorityNumber;
		//����ʱ��
		DateTime startTime;

		//��ȡ��ǰϵͳ�е����н���
		Process[] processes= Process.GetProcesses();

		//����б���ͼ��ԭ�е�����
		if (this.listView1!=null)
		{
			this.listView1.Items.Clear();
		}

		//���б��м���ÿ��������Ŀ����ϸ��Ϣ
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
            //�ж����ȼ���ֵ
			if (priorityNumber==13){prior="��";};
			if (priorityNumber==4){prior="��";};
			if (priorityNumber==8){prior="��׼";};
			if (priorityNumber==24){prior="ʵʱ";};
            //������Ϣ
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
			//����һ�����
			ListViewItem item=new ListViewItem(subItems);
			this.listView1.Items.Insert(i,item);
	   	}		
	    }

		#region Windows Form Designer generated code
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.columnHeader1.Text = "������";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PID";
			this.columnHeader2.Width = 42;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "�߳���";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "cpuռ��ʱ��";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "ռ���ڴ�";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "���ȼ�";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "����ʱ��";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 24);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "�½�����";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(128, 24);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "��������";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(224, 24);
			this.button3.Name = "button3";
			this.button3.TabIndex = 3;
			this.button3.Text = "ˢ���б�";
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
			this.groupBox1.Text = "���̹���";
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
			this.Text = "ϵͳ���̹���";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//������ļ��Ի���
			OpenFileDialog ofDlg = new OpenFileDialog();
			//ѡ���ִ���ļ�
			ofDlg.Filter = "��ִ���ļ� (*.exe)|*.exe|�����ļ�(*.*)|*.*";
			//��ʾ�Ի���
			if(ofDlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					//����ѡ��ĳ���
					Process newProcess = Process.Start(ofDlg.FileName);
					newProcess.EnableRaisingEvents=true;
					//Ϊ������˳����̵��¼�����
					newProcess.Exited += new EventHandler(OnProcessExited);
					//�����б�
					UpdateProcess();
	
				}
					//���������쳣
				catch(ArgumentException aError)
				{
					MessageBox.Show("���ִ���"+aError.Message, "����",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		private void OnProcessExited(object sender, EventArgs e)
		{			
			//ˢ��ListView�ؼ�
			UpdateProcess();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
		    
			//ˢ��ListView�ؼ�
			UpdateProcess();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(this.listView1.SelectedItems.Count>0)
			{
				//��ȡѡ����Ŀ�е�IDֵ
				int processID = Int32.Parse(listView1.SelectedItems[0].SubItems[1].Text);
				//����ID��ȡ����
				Process selectedProcess = Process.GetProcessById(processID);
                selectedProcess.EnableRaisingEvents=true;
				//Ϊ������˳����̵��¼�����
				selectedProcess.Exited += new EventHandler(OnProcessExited);

				//������̻�û���˳�
				if(!selectedProcess.HasExited)
				{
					//����ر�������ʧ��
					if(!selectedProcess.CloseMainWindow())
					{
						//��ʾ�Ƿ�Ҫɱ������
						if(MessageBox.Show("���ܹر�Ӧ�ó��򴰿ڣ���Ҫ������ֹ������",
							"��ʾ",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							try
							{
								//ɱ������
								selectedProcess.Kill();
								//�����б�
								UpdateProcess();

							}
							catch(Exception excep)
							{
								MessageBox.Show(excep.Message, "���ܽ�������", MessageBoxButtons.OK,MessageBoxIcon.Error);
							}
						}
					}
				}
				else
				{
					MessageBox.Show("ѡ�еĽ����Ѿ��˳���", "��ʾ",MessageBoxButtons.OK, MessageBoxIcon.Information);
					UpdateProcess();
				}
			}
			else
			{
				MessageBox.Show("����ѡ��һ����ǰ�������еĽ��̣�", "��ʾ", MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
	
	}
}
