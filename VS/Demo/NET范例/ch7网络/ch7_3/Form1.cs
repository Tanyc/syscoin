using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch7_3
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.GroupBox groupBox1;
		private AxSHDocVw.AxWebBrowser axWebBrowser1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

        //�����ܺ��˵���ҳ��
		private int i=0;
		//������ǰ������ҳ��
		private int j=0;

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			Initial();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		private void Initial()
		{
		this.toolBarButton1.Enabled=false;
		this.toolBarButton2.Enabled=false;	

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "��ַ";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.comboBox1.Location = new System.Drawing.Point(64, 20);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(464, 20);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button1.Location = new System.Drawing.Point(552, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "GO";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(616, 38);
			this.toolBar1.TabIndex = 5;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Text = "����";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton2.Text = "ǰ��";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			this.toolBarButton3.Text = "ֹͣ";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			this.toolBarButton4.Text = "ˢ��";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.ImageIndex = 4;
			this.toolBarButton5.Text = "��ҳ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button1,
																					this.label1,
																					this.comboBox1});
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(616, 58);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// axWebBrowser1
			// 
			this.axWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axWebBrowser1.Enabled = true;
			this.axWebBrowser1.Location = new System.Drawing.Point(0, 96);
			this.axWebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser1.OcxState")));
			this.axWebBrowser1.Size = new System.Drawing.Size(616, 309);
			this.axWebBrowser1.TabIndex = 7;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(616, 405);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.axWebBrowser1,
																		  this.groupBox1,
																		  this.toolBar1});
			this.Name = "Form1";
			this.Text = "���������";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).EndInit();
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

		
		private void comboBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		    //�жϰ��µ��Ƿ���Enter��
			if (e.KeyChar==(char)13)
			{
			  //������ҳ
			  DownLoad(this.comboBox1.Text);
			  //��¼���ʹ�����ַ
			  this.comboBox1.Items.Add(this.comboBox1.Text);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DownLoad(this.comboBox1.Text);
			
		}
		private void DownLoad(string s)
		{     
			//����Navigate��������ڲ���
			System.Object nullObject = 0 ; 
			string str = "" ; 
			System.Object nullObjStr = str ; 
			//���ù��״̬
			Cursor.Current = Cursors.WaitCursor ; 
			axWebBrowser1.Navigate ( s , ref nullObject , ref nullObjStr , ref nullObjStr , ref nullObjStr ) ; 
			//��ԭ���״̬
			Cursor.Current = Cursors.Default ; 
			//���ʹ�����ҳ��1
			i++;
			if (i>1)
			{
				//������ʹ��������ϵ���ҳ������԰����˼���
				this.toolBarButton1.Enabled=true;
			}
		}
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//�õ�������Ϣ�İ�ť
			ToolBarButton eButton=e.Button;
			//������еġ����ˡ� 
			if ( eButton == this.toolBarButton1 ) 
			{ 
				axWebBrowser1.GoBack ( ) ; 				
				//�ɺ�����ҳ����1
				i--;
				//������˵�ǰ����ҳû�пɺ��˵ģ���ôֹͣʹ�ú��˰�ť
				if (i==1)
				{
					this.toolBarButton1.Enabled=false;
				}
				//��ǰ������ҳ����1
				j++;
				//����ʹ��ǰ����ť
				this.toolBarButton2.Enabled=true;
				
			} 
			//������еġ�ǰ���� 
			if ( eButton == this.toolBarButton2 ) 
			{ 
				
				axWebBrowser1.GoForward ( ) ; 
				//��ǰ������ҳ����1
				j--;
				//���û�п�ǰ���İ�ť����ôֹͣʹ��ǰ����ť
				if (j==0)
				{
				this.toolBarButton2.Enabled=false;
				} 
				//���Ժ��˵���ҳ����1
				i++;
				//����ʹ�ú��˰�ť
				this.toolBarButton1.Enabled=true;
			} 
			//������еġ�ֹͣ�� 
			if ( eButton == this.toolBarButton3 ) 
			{ 
				axWebBrowser1.Stop ( ) ; 
			} 
			//������еġ�ˢ�¡� 
			if ( eButton == this.toolBarButton4 ) 
			{ 
				axWebBrowser1.Refresh ( ) ; 
			} 
			//������еġ���ҳ�� 
			if ( eButton == this.toolBarButton5 ) 
			{ 
				axWebBrowser1.GoHome ( ) ; 
			} 

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//������ҳ
			DownLoad(this.comboBox1.Text);
		}
	}
}
