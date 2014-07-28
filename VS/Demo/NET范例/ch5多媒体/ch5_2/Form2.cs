using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.IO;

namespace ch5_2
{
	/// <summary>
	/// Form2 ��ժҪ˵����
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
        //�����ղؼ��ļ�·��
		public  string filePath;
		private AxMediaPlayer.AxMediaPlayer axMediaPlayer1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public  Form2(string fPath)
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			this.filePath=fPath;

			//��ȡ�����ղؼ��ļ�·��
		
            LoadSongs();
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
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

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.axMediaPlayer1 = new AxMediaPlayer.AxMediaPlayer();
			((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3,
																						this.columnHeader4});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 24);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(272, 160);
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
			this.columnHeader3.Text = "��С";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "·��";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(112, 200);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "ɾ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(208, 200);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "ȷ��";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// axMediaPlayer1
			// 
			this.axMediaPlayer1.Location = new System.Drawing.Point(16, 232);
			this.axMediaPlayer1.Name = "axMediaPlayer1";
			this.axMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMediaPlayer1.OcxState")));
			this.axMediaPlayer1.Size = new System.Drawing.Size(64, 8);
			this.axMediaPlayer1.TabIndex = 3;
			this.axMediaPlayer1.Visible = false;
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(304, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.axMediaPlayer1,
																		  this.button2,
																		  this.button1,
																		  this.listView1});
			this.Name = "Form2";
			this.Text = "�ղؼб༭��";
			((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
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

		private void button2_Click(object sender, System.EventArgs e)
		{
		
			//����д�ļ���
			StreamWriter sWriter=new StreamWriter(this.filePath,false,System.Text.Encoding.Default);
			//���б��еĸ�����һд���ļ�֮��
			foreach (ListViewItem item in this.listView1.Items)
			{
				sWriter.WriteLine(item.SubItems[3].Text);	
			}
			//�ر��ļ���
			sWriter.Close();
			this.Close();
	
		}	
	
	}
}
