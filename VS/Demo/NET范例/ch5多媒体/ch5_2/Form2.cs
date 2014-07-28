using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.IO;

namespace ch5_2
{
	/// <summary>
	/// Form2 的摘要说明。
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
        //代表收藏夹文件路径
		public  string filePath;
		private AxMediaPlayer.AxMediaPlayer axMediaPlayer1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public  Form2(string fPath)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.filePath=fPath;

			//获取歌曲收藏夹文件路径
		
            LoadSongs();
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}
		public  void LoadSongs()
		{
			try
			{
				//从文件中读取歌曲列表
				StreamReader fReader=new StreamReader(filePath,System.Text.Encoding.Default);
				//读出一首歌曲信息
				string s=fReader.ReadLine();
				while (s!=null)
				{
					//获得歌曲信息
					this.GetSongInfo(s);
					s=fReader.ReadLine();
				}
				//关闭文件流
				fReader.Close();
			}
				//如果文件不存在就创建一个文件
			catch (FileNotFoundException error)
			{
				File.Create(filePath);
			}
		}


		private void GetSongInfo(string s)
		{
			this.axMediaPlayer1.FileName=s;
			//获得歌曲名称和路径
			string mp3Name=this.axMediaPlayer1.GetMediaInfoString(MediaPlayer.MPMediaInfoType.mpClipTitle);
			string mp3Path=s;

			//获取文件大小
			FileInfo fInfo=new FileInfo(s);
			float size= (float)fInfo.Length/(1024*1024);

			//获取作者信息	
			string author=this.axMediaPlayer1.GetMediaInfoString(MediaPlayer.MPMediaInfoType.mpClipAuthor);
	   
			//构造子项
			string[] subItem={mp3Name,size.ToString().Substring(0,4)+"M",author,s};
			//构造项
			ListViewItem item=new ListViewItem(subItem);
			//插入项
			this.listView1.Items.Add(item);		
		
		}

		/// <summary>
		/// 清理所有正在使用的资源。
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
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
			this.columnHeader1.Text = "曲名";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "作者";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "大小";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "路径";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(112, 200);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "删除";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(208, 200);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "确定";
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
			this.Text = "收藏夹编辑器";
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
					//移除当前曲目
					this.listView1.SelectedItems[0].Remove();			
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		
			//创建写文件流
			StreamWriter sWriter=new StreamWriter(this.filePath,false,System.Text.Encoding.Default);
			//将列表中的歌曲逐一写入文件之中
			foreach (ListViewItem item in this.listView1.Items)
			{
				sWriter.WriteLine(item.SubItems[3].Text);	
			}
			//关闭文件流
			sWriter.Close();
			this.Close();
	
		}	
	
	}
}
