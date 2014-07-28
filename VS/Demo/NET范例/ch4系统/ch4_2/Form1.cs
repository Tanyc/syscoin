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
	/// Form1 ��ժҪ˵����
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
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			DisplayModuals();
			DisplayMemory();
	
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}
			
		private void DisplayModuals()
		{
		
			Process[] ch42;
			ProcessModuleCollection modules;
			//ͨ����������ȡ����
			ch42 = Process.GetProcessesByName("ch4_2");
			// ���ģ�鼯��
			modules = ch42[0].Modules;
			// ����������listBox1��
			foreach (ProcessModule aModule in modules)
			{
				this.listBox1.Items.Add(aModule.ModuleName);
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
			this.groupBox1.Text = "���̼��صĿ�";
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
			this.groupBox2.Text = "�����ڴ�ʹ����ϸ��Ϣ";
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
			this.columnHeader1.Text = "�ڴ�ʹ�����";
			this.columnHeader1.Width = 123;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "��С";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 421);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "������ϸ��Ϣ";
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

			//��ȡר���ڴ��С
			int privateMemory=ch42[0].PrivateMemorySize;
			string[] subitems={"ר���ڴ�",(privateMemory/1024).ToString()+" K"};
			ListViewItem item=new ListViewItem(subitems);
			this.listView1.Items.Add(item);
             
			//��ȡ��ֵ�����ڴ��С
			int peakVirtualMemorySize=ch42[0].PeakVirtualMemorySize;
			string[] subitems1={"��������ڴ�",(peakVirtualMemorySize/1024).ToString()+" K"};
			ListViewItem item1=new ListViewItem(subitems1);
			this.listView1.Items.Add(item1);
		
			//��ȡ��ֵ��ҳ�ڴ��С
			int peakPagedMemorySize=ch42[0].PeakPagedMemorySize;
			string[] subitems2={"����ҳ�ڴ��С",(peakPagedMemorySize/1024).ToString()+" K"};
			ListViewItem item2=new ListViewItem(subitems2);
			this.listView1.Items.Add(item2);

			//��ȡ��ҳ��ϵͳ�ڴ��С
			int pagedSystemMemorySize=ch42[0].PagedSystemMemorySize;
			string[] subitems3={"��ҳ��ϵͳ�ڴ��С",(pagedSystemMemorySize/1024).ToString()+" K"};
			ListViewItem item3=new ListViewItem(subitems3);
			this.listView1.Items.Add(item3);

			//��ȡ��ҳ���ڴ��С
			int pagedMemorySize=ch42[0].PagedMemorySize;
			string[] subitems4={"��ҳ���ڴ��С",(pagedMemorySize/1024).ToString()+" K"};
			ListViewItem item4=new ListViewItem(subitems4);
			this.listView1.Items.Add(item4);
		
			//��ȡδ��ҳ��ϵͳ�ڴ��С��
			int nonpagedSystemMemorySize=ch42[0].NonpagedSystemMemorySize;
			string[] subitems5={"δ��ҳ��ϵͳ�ڴ��С",(nonpagedSystemMemorySize/1024).ToString()+" K"};
			ListViewItem item5=new ListViewItem(subitems5);
			this.listView1.Items.Add(item5);

			//��ȡ�����ڴ�ʹ�����
			int  memorySize=ch42[0].WorkingSet;
			string[] subitems6={"�����ڴ��С",(memorySize/1024).ToString()+" K"};
			ListViewItem item6=new ListViewItem(subitems6);
			this.listView1.Items.Add(item6);

			//��ȡ���̵������ڴ��С
			int  virtualMemorySize=ch42[0].VirtualMemorySize;
			string[] subitems7={"�����ڴ��С",(virtualMemorySize/1024).ToString()+" K"};
			ListViewItem item7=new ListViewItem(subitems7);
			this.listView1.Items.Add(item7);
		}
		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
      
	    
         }
	
	}
