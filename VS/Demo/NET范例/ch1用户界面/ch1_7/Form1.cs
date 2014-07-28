using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_7
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemSet;
		private System.Windows.Forms.MenuItem menuItemColor;
		private System.Windows.Forms.MenuItem menuItemBlue;
		private System.Windows.Forms.MenuItem menuItemRed;
		private System.Windows.Forms.MenuItem menuItemWhite;
		private System.Windows.Forms.MenuItem menuItemFont;
		private System.Windows.Forms.MenuItem menuItemSmall;
		private System.Windows.Forms.MenuItem menuItemMedium;
		private System.Windows.Forms.MenuItem menuItemLarge;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItemOpen;
		private System.Windows.Forms.MenuItem menuItemClose;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ContextMenu contextMenu2;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemSeparator;
        
		//����һ�����������С�Ľṹ
		private struct FontSizes 
		{
			public static float Small = 8f;
			public static float Medium = 16f;
			public static float Large = 24f;
		}
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemOpen = new System.Windows.Forms.MenuItem();
			this.menuItemSeparator = new System.Windows.Forms.MenuItem();
			this.menuItemClose = new System.Windows.Forms.MenuItem();
			this.menuItemSet = new System.Windows.Forms.MenuItem();
			this.menuItemColor = new System.Windows.Forms.MenuItem();
			this.menuItemBlue = new System.Windows.Forms.MenuItem();
			this.menuItemRed = new System.Windows.Forms.MenuItem();
			this.menuItemWhite = new System.Windows.Forms.MenuItem();
			this.menuItemFont = new System.Windows.Forms.MenuItem();
			this.menuItemSmall = new System.Windows.Forms.MenuItem();
			this.menuItemMedium = new System.Windows.Forms.MenuItem();
			this.menuItemLarge = new System.Windows.Forms.MenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenu2 = new System.Windows.Forms.ContextMenu();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemFile,
																					  this.menuItemSet});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemOpen,
																						 this.menuItemSeparator,
																						 this.menuItemClose});
			this.menuItemFile.Text = "�ļ�(&F)";
			// 
			// menuItemOpen
			// 
			this.menuItemOpen.Index = 0;
			this.menuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuItemOpen.Text = "��";
			this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
			// 
			// menuItemSeparator
			// 
			this.menuItemSeparator.Index = 1;
			this.menuItemSeparator.Text = "-";
			// 
			// menuItemClose
			// 
			this.menuItemClose.Index = 2;
			this.menuItemClose.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.menuItemClose.Text = "�˳�";
			this.menuItemClose.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItemSet
			// 
			this.menuItemSet.Index = 1;
			this.menuItemSet.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuItemColor,
																						this.menuItemFont});
			this.menuItemSet.Text = "����(&S)";
			// 
			// menuItemColor
			// 
			this.menuItemColor.Index = 0;
			this.menuItemColor.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuItemBlue,
																						  this.menuItemRed,
																						  this.menuItemWhite});
			this.menuItemColor.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItemColor.Text = "���屳��(&C)";
			// 
			// menuItemBlue
			// 
			this.menuItemBlue.Index = 0;
			this.menuItemBlue.RadioCheck = true;
			this.menuItemBlue.Text = "��ɫ";
			this.menuItemBlue.Click += new System.EventHandler(this.menuItemBlue_Click);
			// 
			// menuItemRed
			// 
			this.menuItemRed.Index = 1;
			this.menuItemRed.RadioCheck = true;
			this.menuItemRed.Text = "��ɫ";
			this.menuItemRed.Click += new System.EventHandler(this.menuItemRed_Click);
			// 
			// menuItemWhite
			// 
			this.menuItemWhite.Index = 2;
			this.menuItemWhite.RadioCheck = true;
			this.menuItemWhite.Text = "��ɫ";
			this.menuItemWhite.Click += new System.EventHandler(this.menuItemWhite_Click);
			// 
			// menuItemFont
			// 
			this.menuItemFont.Index = 1;
			this.menuItemFont.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemSmall,
																						 this.menuItemMedium,
																						 this.menuItemLarge});
			this.menuItemFont.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.menuItemFont.Text = "�����С(&Z)";
			// 
			// menuItemSmall
			// 
			this.menuItemSmall.Index = 0;
			this.menuItemSmall.Text = "С";
			this.menuItemSmall.Click += new System.EventHandler(this.menuItemSmall_Click);
			// 
			// menuItemMedium
			// 
			this.menuItemMedium.Index = 1;
			this.menuItemMedium.Text = "��";
			this.menuItemMedium.Click += new System.EventHandler(this.menuItemMedium_Click);
			// 
			// menuItemLarge
			// 
			this.menuItemLarge.Index = 2;
			this.menuItemLarge.Text = "��";
			this.menuItemLarge.Click += new System.EventHandler(this.menuItemLarge_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.ContextMenu = this.contextMenu1;
			this.richTextBox1.Location = new System.Drawing.Point(56, 40);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(312, 56);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "���һ���ʾ�����˵�";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "�ı��ļ� (*.txt)|*.txt";
			this.openFileDialog1.InitialDirectory = "C:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(416, 153);
			this.ContextMenu = this.contextMenu2;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "�˵����";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			//�˳�����
			this.Close();
		}

		private void menuItemBlue_Click(object sender, System.EventArgs e)
		{
			//���ñ�����ɫ
			this.BackColor=Color.Blue;
		    //�ı�˵����Checked����
			menuItemBlue.Checked=true;
			menuItemRed.Checked=false;
			menuItemWhite.Checked=false;
		}

		private void menuItemRed_Click(object sender, System.EventArgs e)
		{
			//���ñ�����ɫ
			this.BackColor=Color.Red;
			//�ı�˵����Checked����
			menuItemBlue.Checked=false;
			menuItemRed.Checked=true;
			menuItemWhite.Checked=false;
		}

		private void menuItemWhite_Click(object sender, System.EventArgs e)
		{
			//���ñ�����ɫ
			this.BackColor=Color.White;
			//�ı�˵����Checked����
			menuItemBlue.Checked=false;
			menuItemRed.Checked=false;
			menuItemWhite.Checked=true;
		}

		private void menuItemSmall_Click(object sender, System.EventArgs e)
		{
			//�ı�˵����Checked����
			menuItemSmall.Checked=true;
			menuItemMedium.Checked=false;
			menuItemLarge.Checked=false;
			//���������С
			this.richTextBox1.Font=new Font("С����",FontSizes.Small);
		}

		private void menuItemMedium_Click(object sender, System.EventArgs e)
		{
			//�ı�˵����Checked����
			menuItemSmall.Checked=false;
			menuItemMedium.Checked=true;
			menuItemLarge.Checked=false;
            //���������С
			this.richTextBox1.Font=new Font("������",FontSizes.Medium);
		}

		private void menuItemLarge_Click(object sender, System.EventArgs e)
		{
			//�ı�˵����Checked����
			menuItemSmall.Checked=false;
			menuItemMedium.Checked=false;
			menuItemLarge.Checked=true;
			//���������С
			this.richTextBox1.Font=new Font("������",FontSizes.Large);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{ 
            //ΪcontextMenu1���Ʋ˵���
			this.contextMenu1.MenuItems.Add(this.menuItemFont.CloneMenu());
			//ΪcontextMenu2���Ʋ˵���
		    this.contextMenu2.MenuItems.Add(this.menuItemColor.CloneMenu());
		}

		private void menuItemOpen_Click(object sender, System.EventArgs e)
		{
			//��ʾopenFileDialog1�Ի���ѡ��һ���ı��ļ�
			this.openFileDialog1.ShowDialog();
		}

	
	

	
	}
}
