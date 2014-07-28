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
	/// Form1 ��ժҪ˵����
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
			// Windows ���������֧���������
			//
			InitializeComponent();

			LoadEventLog();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		private void LoadEventLog()
		{
		    //����һ����־����
			EventLog  systemEvent=new EventLog();
			//˵�������־��ϵͳ��־
			systemEvent.Log="System";
			//���ϵͳ��־�ļ�¼����
		    eventCollection=systemEvent.Entries;

			//��¼�ĳ���
			int length=eventCollection.Count;
			for (int i=0;i<length;i++)
			{
				EventLogEntry entry=eventCollection[length-i-1];
			    //����һ��ListViewItem������
				string[] subItems={
								      //����
									  entry.EntryType.ToString(),
									  //����
									  entry.TimeGenerated.ToLongDateString(),
									  //ʱ��
				                      entry.TimeGenerated.ToLongTimeString(),
									  //��Դ
									  entry.Source,
									  //����
									  entry.Category,
									  //�¼�
									  entry.EventID.ToString(),
									  //�û�
				                      entry.UserName,
									  //�������
									  entry.MachineName
								  };

				ListViewItem  item=new ListViewItem(subItems);
				//��Ӽ�¼
				this.listView1.Items.Add(item);			
			}
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

		#region Windows Form Designer generated code
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.columnHeader1.Text = "����";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "����";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "ʱ��";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "��Դ";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "����";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "�¼�";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "�û�";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "�����";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(384, 336);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "������־";
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
			this.menuItem1.Text = "�¼���ϸ��Ϣ";
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
			this.Text = "ϵͳ��־�鿴";
			this.panel1.ResumeLayout(false);
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
            //��ռ�¼
			this.listView1.Items.Clear();		  
			//������־
			LoadEventLog();

		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
	     //��ȡָ����¼��listView�е�����
		 int i=this.listView1.SelectedItems[0].Index;
		 //��ȡ��¼������Ŀ
         int length=this.eventCollection.Count;
		 //��ȡָ����¼����Ϣ
		 string message=eventCollection[length-i-1].Message;
		 //������Ϣ��
         MessageBox.Show("������־����ϸ��Ϣ�ǣ� "+message,"��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);

		}
	}
}
