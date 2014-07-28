using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;

namespace ch5_2
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private AxMediaPlayer.AxMediaPlayer axMediaPlayer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button10;

		//�����ղؼе��ļ�·��
		private string filePath;

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//��ȡ�����ղؼ��ļ�·��
			string current =Directory.GetCurrentDirectory();
			filePath=current+"\\mymp3.lst";
            //�ڸ����б�����ʾ�ղ��ļ��еĸ���
			LoadSongs();
	
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

		public  void LoadSongs()
		{
		   	try
			{
				//���ļ��ж�ȡ�����б�
				StreamReader fReader=new StreamReader(filePath,System.Text.Encoding.Default);
				//����һ�׸�����Ϣ
				string s=fReader.ReadLine();
				while (s!=null)
				{
				    //��ø�����Ϣ
    				this.GetSongInfo(s);
					s=fReader.ReadLine();
				}
                //�ر��ļ���
                fReader.Close();
			}
				//����ļ������ھʹ���һ���ļ�
			catch (FileNotFoundException error)
			{
                File.Create(filePath);
			}
		}


		private void GetSongInfo(string s)
		{
		    this.axMediaPlayer1.FileName=s;
			//��ø������ƺ�·��
			string mp3Name=this.axMediaPlayer1.GetMediaInfoString(MediaPlayer.MPMediaInfoType.mpClipTitle);
			string mp3Path=s;

			//��ȡ�ļ���С
			FileInfo fInfo=new FileInfo(s);
			float size= (float)fInfo.Length/(1024*1024);

			//��ȡ������Ϣ	
			string author=this.axMediaPlayer1.GetMediaInfoString(MediaPlayer.MPMediaInfoType.mpClipAuthor);
	   
			//��������
			string[] subItem={mp3Name,size.ToString().Substring(0,4)+"M",author,s};
			//������
			ListViewItem item=new ListViewItem(subItem);
			//������
			this.listView1.Items.Add(item);		
		
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.axMediaPlayer1 = new AxMediaPlayer.AxMediaPlayer();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// axMediaPlayer1
			// 
			this.axMediaPlayer1.Location = new System.Drawing.Point(0, 336);
			this.axMediaPlayer1.Name = "axMediaPlayer1";
			this.axMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMediaPlayer1.OcxState")));
			this.axMediaPlayer1.Size = new System.Drawing.Size(320, 24);
			this.axMediaPlayer1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 21);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(240, 8);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "�����ղؼ�";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader4,
																						this.columnHeader3});
			this.listView1.ContextMenu = this.contextMenu1;
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 80);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(304, 200);
			this.listView1.TabIndex = 5;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "����";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "��С";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "����";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "·��";
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1,
																						 this.menuItem2,
																						 this.menuItem3,
																						 this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "ɾ����ǰ";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "ɾ��ȫ��";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "ѡ����Ŀ";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new System.Drawing.Point(72, 48);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 24);
			this.button3.TabIndex = 6;
			this.button3.Text = "����";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Location = new System.Drawing.Point(136, 48);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 24);
			this.button5.TabIndex = 8;
			this.button5.Text = "ֹͣ";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Location = new System.Drawing.Point(200, 48);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(56, 24);
			this.button6.TabIndex = 9;
			this.button6.Text = "ǰһ��";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button7.Location = new System.Drawing.Point(256, 48);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(56, 24);
			this.button7.TabIndex = 10;
			this.button7.Text = "��һ��";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(104, 296);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(104, 23);
			this.button8.TabIndex = 12;
			this.button8.Text = "��������б�";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(208, 296);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(104, 23);
			this.button9.TabIndex = 13;
			this.button9.Text = "��������б�";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(8, 48);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 24);
			this.button4.TabIndex = 14;
			this.button4.Text = "�ҵ��ղ�";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(8, 296);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(96, 23);
			this.button10.TabIndex = 15;
			this.button10.Text = "�༭�ղؼ�";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button10,
																		  this.button4,
																		  this.button9,
																		  this.button8,
																		  this.button7,
																		  this.button6,
																		  this.button5,
																		  this.button3,
																		  this.button2,
																		  this.textBox1,
																		  this.button1,
																		  this.axMediaPlayer1,
																		  this.listView1});
			this.Name = "Form1";
			this.Text = "mp3 ������";
			((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).EndInit();
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
  			OpenFileDialog ofDialog=new OpenFileDialog();
            //���ù�����
			ofDialog.Filter="mp3 �ļ�(*.mp3)|*.mp3|�����ļ�(*.*)|*.*";
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
				try
				{
					//��ò����ļ���
					string s=ofDialog.FileName;
					//���ò��������ļ���
					axMediaPlayer1.FileName=s;
					//��������
					axMediaPlayer1.Play();
					this.textBox1.Text=s;
 
					//��ø�����Ϣ
				    this.GetSongInfo(s);
				}
				catch
				{
					//������
					MessageBox.Show("�޷����Ŵ��ļ�","����",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (this.textBox1.Text!="")
			{
			    string   s=this.textBox1.Text;
				try
				{
					//����һ��д�ļ���
					StreamWriter fWriter=new StreamWriter(this.filePath,true,System.Text.Encoding.Default);
					//������·��д���ļ�
					fWriter.WriteLine(s);
					//�ر��ļ���
                    fWriter.Close();

				}
				catch (DirectoryNotFoundException error)
				{
		        	//����ļ��������򴴽�һ�����ļ���Ȼ�󽫸���·��д���ļ�
					File.Create(this.filePath);
					StreamWriter fWriter=new StreamWriter(this.filePath,true,System.Text.Encoding.Default);
					fWriter.WriteLine(s);
					fWriter.Close();
				}				
			}
		}

		private void listView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//�����ѡ�еĸ����Ͳ������׸�
			if (this.listView1.SelectedItems.Count!=0)
			{
				//��ø�������ϸ·��
				string fileName=this.listView1.SelectedItems[0].SubItems[3].Text;
				this.axMediaPlayer1.FileName=fileName;
				this.axMediaPlayer1.Play();
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//�����ѡ�еĸ����Ͳ������׸�
			if (this.listView1.SelectedItems.Count!=0)
			{
				//��ø�������ϸ·��
				this.axMediaPlayer1.FileName=this.listView1.SelectedItems[0].SubItems[3].Text;
				this.axMediaPlayer1.Play();
			}
		}


		private void button5_Click(object sender, System.EventArgs e)
		{
			//������������ڷ����֣���ֹͣ����
			if (this.axMediaPlayer1.FileName!="")
			{
				this.axMediaPlayer1.Stop();
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			if (this.listView1.Items.Count!=0)
			{
				if (this.listView1.SelectedItems.Count==0)
				{
				}
				else 
				{
					if (this.listView1.SelectedItems[0].Index==0)
					{
					}
					else
					{
						//ѡ��λ����ǰ�ƶ�һ��
						int pos=this.listView1.SelectedItems[0].Index-1;
						//��ǰѡ������ȡ��
						this.listView1.SelectedItems[0].Selected=false;
						//�����µ�ѡ����
						this.listView1.Items[pos].Selected=true;
 
						//���ŵ�ǰѡ����
						string fileName=this.listView1.SelectedItems[0].SubItems[3].Text;
						this.axMediaPlayer1.FileName=fileName;
						this.axMediaPlayer1.Play();
					}
				}
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			if (this.listView1.Items.Count!=0)
			{
				if (this.listView1.SelectedItems.Count==0)
				{
				}
				else
				{
					if (this.listView1.SelectedItems[0].Index+1==this.listView1.Items.Count)
					{
					}
					else 
					{
						//ѡ��λ����ǰ�ƶ�һ��
						int pos=this.listView1.SelectedItems[0].Index+1;
						//��ǰѡ������ȡ��
						this.listView1.SelectedItems[0].Selected=false;
						//�����µ�ѡ����
						this.listView1.Items[pos].Selected=true;
 
						//���ŵ�ǰѡ����
						string fileName=this.listView1.SelectedItems[0].SubItems[3].Text;
						this.axMediaPlayer1.FileName=fileName;
						this.axMediaPlayer1.Play();

				    
					}
				}
			}
			
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			if (this.listView1.Items.Count!=0)
			{
				if (this.listView1.SelectedItems.Count!=0)
				{
					//�Ƴ���ǰ��Ŀ
					this.listView1.SelectedItems[0].Remove();		
				}
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			//ɾ�����е���Ŀ
			this.listView1.Items.Clear();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button8_Click(object sender, System.EventArgs e)
		{

			SaveFileDialog sDialog=new SaveFileDialog();
			//���ù�����
			sDialog.Filter="�����б��ļ�(*.lst)|*.lst|�����ļ�(*.*)|*.*";
			if (sDialog.ShowDialog()==DialogResult.OK)
			{
			//�õ������ļ���
			string fileName=sDialog.FileName;
			//����д�ļ���
			StreamWriter sWriter=new StreamWriter(fileName,false,System.Text.Encoding.Default);
			//���б��еĸ�����һд���ļ�֮��
			foreach (ListViewItem item in this.listView1.Items)
				{
			      sWriter.WriteLine(item.SubItems[3].Text);	
				}
			//�ر��ļ���
			sWriter.Close();
        	}	

		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog oDialog=new OpenFileDialog();
			//���ù�����
			oDialog.Filter="�����б��ļ�(*.lst)|*.lst|�����ļ�(*.*)|*.*";
			if (oDialog.ShowDialog()==DialogResult.OK)
			{
				//�õ����ص��ļ���
				string fileName=oDialog.FileName;
				//�������ļ���
				StreamReader sReader=new StreamReader(fileName,System.Text.Encoding.Default);
				//����б�
				this.listView1.Items.Clear();
				//��һ���ļ��еĸ�����Ϣд���б���
				string s=sReader.ReadLine();
				while (s!=null)
				{
				 this.GetSongInfo(s);
				 s= sReader.ReadLine();
				 
				}
				//�ر��ļ���
				sReader.Close();
			}	
		}


		private void button4_Click(object sender, System.EventArgs e)
		{
			//���listView1
			this.listView1.Items.Clear();
			//�����ղؼеĸ����б�
			this.LoadSongs();
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			Form2 form2=new Form2(this.filePath);
			//���ղؼб༭��
			form2.Show();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
		      
			//ʹ��button1_Click���¼��������
			this.button1_Click(this,e);
		}
	}
}
