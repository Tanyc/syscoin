using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_18
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.MenuItem menuItem3;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.AllowDrop = true;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5,
																						this.toolBarButton6,
																						this.toolBarButton7});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(368, 41);
			this.toolBar1.TabIndex = 0;
			this.toolTip1.SetToolTip(this.toolBar1, "������ʾ��");
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.DropDownMenu = this.contextMenu1;
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButton1.Text = "�½�";
			this.toolBarButton1.ToolTipText = "�½�һ���ĵ�";
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1,
																						 this.menuItem2,
																						 this.menuItem3});
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "�ı��ĵ�";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "Word�ĵ�";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Text = "��";
			this.toolBarButton2.ToolTipText = "���ļ�";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Text = "����";
			this.toolBarButton3.ToolTipText = "�����ļ�";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Text = "����";
			this.toolBarButton5.ToolTipText = "�����ı�";
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.Text = "����";
			this.toolBarButton6.ToolTipText = "�����ı�";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Text = "ճ��";
			this.toolBarButton7.ToolTipText = "ճ���ı�";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 15);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(24, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 264);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "���������";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radioButton4);
			this.groupBox3.Controls.Add(this.radioButton3);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Location = new System.Drawing.Point(24, 168);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(248, 64);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "���������";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(88, 24);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(48, 24);
			this.radioButton4.TabIndex = 1;
			this.radioButton4.Text = "ˮƽ";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(16, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(48, 24);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.Text = "����";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(152, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "��ťͼƬ";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Location = new System.Drawing.Point(24, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(248, 72);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "��ť���";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(128, 32);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "�л���ť";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(16, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "��ά��ť";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "�ޱ߿�",
														   "���б߿�",
														   "��ά�߿�"});
			this.comboBox1.Location = new System.Drawing.Point(128, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(144, 20);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "�������߿�";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "doc1";
			// 
			// groupBox4
			// 
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(0, 41);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(368, 8);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.menuItem3.Text = "luna";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(368, 357);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.toolBar1);
			this.Name = "Form1";
			this.Text = "������";
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string s=this.comboBox1.SelectedItem.ToString();

		    //����ToolBar�ı߿���
			switch (s)
			{
				case "�ޱ߿�":
					this.toolBar1.BorderStyle=BorderStyle.None;
					break;
				case "���б߿�":
					this.toolBar1.BorderStyle=BorderStyle.FixedSingle;
					break;
				case "��ά�߿�":
					this.toolBar1.BorderStyle=BorderStyle.Fixed3D;
					break;
			}
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.radioButton1.Checked==true)
			{
			this.toolBarButton2.Style=ToolBarButtonStyle.PushButton;
			this.toolBarButton3.Style=ToolBarButtonStyle.PushButton;
			this.toolBarButton5.Style=ToolBarButtonStyle.PushButton;
			this.toolBarButton6.Style=ToolBarButtonStyle.PushButton;
			this.toolBarButton7.Style=ToolBarButtonStyle.PushButton;
            this.radioButton2.Checked=false;
			}
	}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.radioButton2.Checked==true)
			{
			this.toolBarButton2.Style=ToolBarButtonStyle.ToggleButton;
			this.toolBarButton3.Style=ToolBarButtonStyle.ToggleButton;
			this.toolBarButton5.Style=ToolBarButtonStyle.ToggleButton;
			this.toolBarButton6.Style=ToolBarButtonStyle.ToggleButton;
			this.toolBarButton7.Style=ToolBarButtonStyle.ToggleButton;
			this.radioButton1.Checked=false;
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.radioButton3.Checked==true)
			{
			this.toolBar1.Appearance=ToolBarAppearance.Normal;
			this.radioButton4.Checked=false;
			}
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.radioButton4.Checked==true)
			{
				this.toolBar1.Appearance=ToolBarAppearance.Flat;
				this.radioButton3.Checked=false;
			}
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		MessageBox.Show("���ڴ���һ���ı��ļ�","��ʾ",MessageBoxButtons.OKCancel);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
		MessageBox.Show("���ڴ���һ��Word�ĵ�","��ʾ",MessageBoxButtons.OKCancel);
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.checkBox1.Checked==true)
			{
				this.toolBar1.ImageList=this.imageList1;
				//Ϊÿ����ť����ͼƬ
				this.toolBarButton1.ImageIndex=0;
				this.toolBarButton2.ImageIndex=1;
				this.toolBarButton3.ImageIndex=2;
				this.toolBarButton5.ImageIndex=3;
				this.toolBarButton6.ImageIndex=4;
				this.toolBarButton7.ImageIndex=5;
			}
			else
			{
			this.toolBar1.ImageList=null;
			}
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
		    //�жϵ�������ĸ���ť��Ȼ��������Ӧ�Ķ���	
			if (e.Button==this.toolBarButton2)
			{
			this.openFileDialog1.ShowDialog();
			}

			if (e.Button==this.toolBarButton3)
			{
			this.saveFileDialog1.ShowDialog();
			}

			if (e.Button==this.toolBarButton5)
			{
			MessageBox.Show("�Ѽ�����ָ���ı�");
			}

			if (e.Button==this.toolBarButton6)
			{
			MessageBox.Show("�ѿ�����ָ���ı�");
			}

			if (e.Button==this.toolBarButton7)
			{
			MessageBox.Show("��ճ����ָ���ı�");
			}
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Luna","��ʾ",MessageBoxButtons.OKCancel);
		}

		
	}
}
