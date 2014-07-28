using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_11
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
	    public  System.Windows.Forms.ListView listView1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button button1;
    	private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader phone;
		private System.Windows.Forms.ColumnHeader email;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button button3;
		private static bool sort=false;
		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
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

		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "张明", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)))),
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "9900009"),
																																								new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "zhangming@somesite.com")}, 0);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.listView1 = new System.Windows.Forms.ListView();
			this.name = new System.Windows.Forms.ColumnHeader();
			this.phone = new System.Windows.Forms.ColumnHeader();
			this.email = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.name,
																						this.phone,
																						this.email});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView1.FullRowSelect = true;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
																					  listViewItem1});
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(368, 152);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			// 
			// name
			// 
			this.name.Text = "姓名";
			this.name.Width = 100;
			// 
			// phone
			// 
			this.phone.Text = "电话";
			this.phone.Width = 100;
			// 
			// email
			// 
			this.email.Text = "邮件";
			this.email.Width = 100;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 144);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button3,
																					this.button2,
																					this.textBox3,
																					this.textBox2,
																					this.textBox1,
																					this.label3,
																					this.label2,
																					this.label1,
																					this.button1});
			this.groupBox1.Location = new System.Drawing.Point(8, 176);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 184);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "新建名片";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(224, 144);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(72, 24);
			this.button3.TabIndex = 7;
			this.button3.Text = "删除";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(120, 144);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 24);
			this.button2.TabIndex = 6;
			this.button2.Text = "取消";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(96, 104);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(184, 21);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(96, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 21);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(96, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 21);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "邮件";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "电话";
			// 
			// label1
			// 
			this.label1.ImageList = this.imageList1;
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "姓名";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(368, 381);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.listView1});
			this.Name = "Form1";
			this.Text = "个人名片夹";
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
            String name=this.textBox1.Text;
			String phone=this.textBox2.Text;
			String email=this.textBox3.Text;
		   //判断填入的信息是否为空，如果为空，则会弹出一个Messagebox提示相应的错误
			if (name!="" & phone !="" & email!="")
			{
			    //给listView1添加新项
				int number=this.listView1.Items.Count;
				ListViewItem lvItem = new ListViewItem(new ListViewItem.ListViewSubItem[]
                       {
							new ListViewItem.ListViewSubItem(null,name),
							new ListViewItem.ListViewSubItem(null,phone),
							new ListViewItem.ListViewSubItem(null,email)
						},-1);
				this.listView1.Items.Insert(number,lvItem);
				//设置小图标
				this.listView1.Items[number].ImageIndex=0;
			}
			else if (name=="")
			{
				MessageBox.Show("请输入姓名","警告");
			}
			else if (phone=="")
			{
				MessageBox.Show("请输入电话号码","警告");
			}
			else if (email=="")
			{
			    MessageBox.Show("请输入email地址","警告");
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		//将输入框的Text全部置空
		this.textBox1.Text="";
		this.textBox2.Text="";
		this.textBox3.Text="";
		}

		

		
		private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
				//单击listView1的Column，使得它的Sorting属性在true和false之间改变
			if (sort==false)
			{
				this.listView1.Sorting = SortOrder.Ascending;
				sort=true;
			}
			else if(sort==true)
			{
				this.listView1.Sorting = SortOrder.Descending;
				sort=false;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//删除选定的项
			ListViewItem li=this.listView1.SelectedItems[0];
			this.listView1.Items.Remove(li);
		}

	
	
	}
}
