using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch3_8
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.ComponentModel.IContainer components;
        
		//�������10���ڼ������ϱ��������
		private string[] clipboardText=new string[]{"","","","","","","","","",""};

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(416, 37);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 37);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(416, 304);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 15);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.DropDownMenu = this.contextMenu1;
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Text = "����";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton2.Text = "����";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.DropDownMenu = this.contextMenu1;
			this.toolBarButton3.ImageIndex = 2;
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButton3.Text = "ճ��";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(416, 341);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1,
																		  this.toolBar1});
			this.Name = "Form1";
			this.Text = "������ѭ��";
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

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			//����Ǽ��л��߸��ư�ť�����
			if (e.Button==this.toolBarButton1 | e.Button==this.toolBarButton2)
			{   
				//���Ҫ�����������ַ���
			    string s=this.richTextBox1.SelectedText;

				//ʵ�ּ��а�ť�Ĺ���
				if (e.Button==this.toolBarButton1)
				{
				//������Ҫ���ַ�������
				this.richTextBox1.SelectedText="";
				
				}
			
			    //ʵ�ֿ����ͼ��й�ͬ�Ĺ���

				//���ַ����ŵ���������
				Clipboard.SetDataObject(s);

				//����Ϊճ����ť��̬��Ӳ˵�
				if (this.contextMenu1!=null )
				{
					//�����˵�����Ŀ���������10�����
					int i=this.contextMenu1.MenuItems.Count;
					if (i<10)
					{
						//���ò˵����Text���ԣ����15���ַ��Ĳ��ֲ���ʾ
						MenuItem newItem=new MenuItem("�ı���"+s);
						if (s.Length>15)
						{
							newItem.Text="�ı���"+s.Substring(0,15)+"...";
						} 
						//Ϊ�˵����click��ť����¼��������
						newItem.Click+=new EventHandler(menuItemClick);
                        //��̬��Ӳ˵���
						this.contextMenu1.MenuItems.Add(newItem);

				        //�����������ַ�����������
						this.clipboardText[i]=s;
					}

					//�������10������յ�һ��˵��������������
					else
					{
						string temp=this.clipboardText[0];
						//���ò˵����Text���ԣ����15���ַ��Ĳ��ֲ���ʾ
                        MenuItem newItem=new MenuItem("�ı���"+s);
						if (s.Length>15)
						{
							 newItem.Text="�ı���"+s.Substring(0,15)+"...";
						} 
                        newItem.Click+=new EventHandler(menuItemClick);

                        //����ԭ���˵���0-9���Ϊ�²˵����2-10��
						this.clipboardText[0]=s;
						for (int j=0;j<9;j++)
						{
						string temp1=this.clipboardText[j+1];
						this.clipboardText[j+1]=temp;
						this.contextMenu1.MenuItems[j+1].Text="�ı���"+temp;
						temp=temp1;
						}
						
					}
				}
				else
				{
					//��ʼ����һ���˵���
					MenuItem newItem=new MenuItem("�ı���"+s);
					if (s.Length>15)
					{
						newItem.Text="�ı���"+s.Substring(0,15)+"...";
					} 
					newItem.Click+=new EventHandler(menuItemClick);
					this.contextMenu1.MenuItems.Add(newItem);
					this.contextMenu1.MenuItems[0].Text="�ı���"+s;
					this.clipboardText[0]=s;
				}

			}
			//ʵ��ճ����ť�Ĺ���
			if (e.Button==this.toolBarButton3)
			{
				try
				{
					IDataObject d = Clipboard.GetDataObject ( ) ;
					//�жϼ��а��������ǲ����ı�
					if ( d.GetDataPresent ( DataFormats.UnicodeText ) ) 
					{
						//���ı�����ճ�����ı�������
						this.richTextBox1.Paste();
						
					}
					else
					{
						//�����������û���ı����򷢳�����
						MessageBox.Show("û�п�ճ�����ı�","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					}
				}
				catch(Exception error)
				{
					//��ȡ�����������		
					MessageBox.Show("������Ϣ�ǣ� "+error.Message,"����",MessageBoxButtons.OK,MessageBoxIcon.Error);

				}
			}
		}
	
		//�˵����¼�����
		private void menuItemClick (object sender, System.EventArgs e)
		{
	    //��ȡ������Ϣ�Ĳ˵���
		MenuItem mItem=(MenuItem)sender;
		//��ò˵�������
		int i =mItem.Index;
		//�ŵ�������
		Clipboard.SetDataObject(this.clipboardText[i]);
		//��������richTextBox��
		this.richTextBox1.Paste();	
		}
	}

}
