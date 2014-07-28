using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_12
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel sBarTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.StatusBarPanel sBarKeyState;
		private System.Windows.Forms.StatusBarPanel sBarPostion;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.sBarPostion = new System.Windows.Forms.StatusBarPanel();
			this.sBarTime = new System.Windows.Forms.StatusBarPanel();
			this.sBarKeyState = new System.Windows.Forms.StatusBarPanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.sBarPostion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sBarTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sBarKeyState)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(312, 273);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
			this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 241);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.sBarPostion,
																						  this.sBarTime,
																						  this.sBarKeyState});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(312, 32);
			this.statusBar1.TabIndex = 1;
			this.statusBar1.Text = "statusBar1";
			// 
			// sBarPostion
			// 
			this.sBarPostion.Text = "����";
			this.sBarPostion.Width = 140;
			// 
			// sBarTime
			// 
			this.sBarTime.Text = "time";
			// 
			// sBarKeyState
			// 
			this.sBarKeyState.Text = "INS";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(312, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.statusBar1,
																		  this.richTextBox1});
			this.Name = "Form1";
			this.Text = "�๦��״̬��";
			((System.ComponentModel.ISupportInitialize)(this.sBarPostion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sBarTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sBarKeyState)).EndInit();
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

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			//��״̬������ʾϵͳʱ��
			DateTime dTime=DateTime.Now;
			string s= dTime.ToLongTimeString();
			this.sBarTime.Text=s;
		}


		private void richTextBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//��������Ϣ�������Insert�͸ı�״̬����״̬
			if (e.KeyCode == Keys.Insert) 
			{
				string s = this.sBarKeyState.Text;
				if (s.Equals("INS"))
					this.sBarKeyState.Text = "OVR";
				else
					this.sBarKeyState.Text = "INS";
			}
		}

		private void richTextBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//������λ�ã��ı�״̬��
			int x=Cursor.Position.X;
			int y=Cursor.Position.Y;
			this.sBarPostion.Text="���λ�� X="+x.ToString()+"  Y="+y.ToString();
	
		}

		
	}
}
