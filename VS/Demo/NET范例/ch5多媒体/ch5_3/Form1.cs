using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;

namespace ch5_3
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;

        //��ʼ�����������ʷ��¼������
		private  string[] path={"","","",""};
		//����Ŀǰ���в����Ĳ˵�������
		private  int index=0;
		//����洢������ʷ��¼���ļ�·��
		private  string filePath;

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

	
       
		#region Windows Form Designer generated code
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
			this.SuspendLayout();
			// 
			// axShockwaveFlash1
			// 
			this.axShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axShockwaveFlash1.Enabled = true;
			this.axShockwaveFlash1.Name = "axShockwaveFlash1";
			this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
			this.axShockwaveFlash1.Size = new System.Drawing.Size(392, 273);
			this.axShockwaveFlash1.TabIndex = 0;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem9,
																					  this.menuItem10});
			this.menuItem1.Text = "�ļ� (&F)";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "��(&O)";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem11,
																					  this.menuItem12,
																					  this.menuItem13,
																					  this.menuItem14});
			this.menuItem3.Text = "���";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "1";
			this.menuItem11.Visible = false;
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = "2";
			this.menuItem12.Visible = false;
			this.menuItem12.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "3";
			this.menuItem13.Visible = false;
			this.menuItem13.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 3;
			this.menuItem14.Text = "4";
			this.menuItem14.Visible = false;
			this.menuItem14.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "-";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.Text = "�˳�(&X)";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8});
			this.menuItem4.Text = "����(&C)";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "����";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "�ط�";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 2;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Checked = true;
			this.menuItem8.Index = 3;
			this.menuItem8.Text = "ѭ��";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.axShockwaveFlash1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Flash������";
			this.Closed += new System.EventHandler(this.Form1_Closed);
			((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
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

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog oDialog= new OpenFileDialog();
			//���ù�����
			oDialog.Filter="Flash����(*.swf)|*.swf|�����ļ�(*.*)|*.*";
			if (oDialog.ShowDialog()==DialogResult.OK)
			{
			  //����ѡ����falsh
			  string fileName=oDialog.FileName;
			  this.axShockwaveFlash1.Movie=fileName;
    		  this.axShockwaveFlash1.Play();

			  //�ı�˵���
			  this.menuItem3.MenuItems[index].Text=fileName;
			  //�ò˵���ɼ�
			  this.menuItem3.MenuItems[index].Visible=true;
			  //�ı������¼
			  this.path[index]=fileName;
			  //�ı�˵�������
			  index++;
              if (index==4)
			  {
			  index=0;
			  }
    		}



		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
		    this.Close();
			Application.Exit();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
		    this.axShockwaveFlash1.Play();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			this.axShockwaveFlash1.Rewind();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			//�ı�axShockwaveFlash1��loop״̬
			if (this.axShockwaveFlash1.Loop==true)
			{
				this.axShockwaveFlash1.Loop=false;
				this.menuItem8.Checked=false;
			}
			else
			{
				this.axShockwaveFlash1.Loop=true;
				this.menuItem8.Checked=true;
			}
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			//�õ�������Ϣ���Ӳ˵�
			MenuItem item=(MenuItem)sender;
			//�õ���������
			int index=item.Index;
			//�õ�·��
			string fileName=this.path[index];
			//���Ŷ���
			this.axShockwaveFlash1.Movie=fileName;
			this.axShockwaveFlash1.Play();
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
		   
			if (this.filePath!=null)
			{
				StreamWriter sWriter=new StreamWriter(this.filePath,false,System.Text.Encoding.Default);
			
				foreach (string s in this.path)
				{
					sWriter.WriteLine(s);
				}
				sWriter.Close();
			}

		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			if (this.filePath!=null)
			{
				//�½�һ��д�ļ���
				StreamWriter sWriter=new StreamWriter(this.filePath,false,System.Text.Encoding.Default);
				//����ʷ��¼���������ȫ��д���ļ�
				foreach (string s in this.path)
				{
					sWriter.WriteLine(s);
				}
				//�ر��ļ���
				sWriter.Close();
			}
			//�˳�����
			Application.Exit();
		}
	}
}
