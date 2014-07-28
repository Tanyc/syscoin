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
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private AxMediaPlayer.AxMediaPlayer axMediaPlayer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// 必需的设计器变量。
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

		//代表收藏夹的文件路径
		private string filePath;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//获取歌曲收藏夹文件路径
			string current =Directory.GetCurrentDirectory();
			filePath=current+"\\mymp3.lst";
            //在歌曲列表中显示收藏文件中的歌曲
			LoadSongs();
	
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
		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
			this.button1.Text = "打开";
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
			this.button2.Text = "加入收藏夹";
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
			this.columnHeader1.Text = "曲名";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "大小";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "作者";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "路径";
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
			this.menuItem1.Text = "删除当前";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "删除全部";
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
			this.menuItem4.Text = "选定曲目";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new System.Drawing.Point(72, 48);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 24);
			this.button3.TabIndex = 6;
			this.button3.Text = "播放";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Location = new System.Drawing.Point(136, 48);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 24);
			this.button5.TabIndex = 8;
			this.button5.Text = "停止";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.Location = new System.Drawing.Point(200, 48);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(56, 24);
			this.button6.TabIndex = 9;
			this.button6.Text = "前一首";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button7.Location = new System.Drawing.Point(256, 48);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(56, 24);
			this.button7.TabIndex = 10;
			this.button7.Text = "后一首";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(104, 296);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(104, 23);
			this.button8.TabIndex = 12;
			this.button8.Text = "保存歌曲列表";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(208, 296);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(104, 23);
			this.button9.TabIndex = 13;
			this.button9.Text = "载入歌曲列表";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(8, 48);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 24);
			this.button4.TabIndex = 14;
			this.button4.Text = "我的收藏";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(8, 296);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(96, 23);
			this.button10.TabIndex = 15;
			this.button10.Text = "编辑收藏夹";
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
			this.Text = "mp3 播放器";
			((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer1)).EndInit();
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
  			OpenFileDialog ofDialog=new OpenFileDialog();
            //设置过滤器
			ofDialog.Filter="mp3 文件(*.mp3)|*.mp3|所有文件(*.*)|*.*";
			if (ofDialog.ShowDialog()==DialogResult.OK)
			{
				try
				{
					//获得播放文件名
					string s=ofDialog.FileName;
					//设置播放器的文件名
					axMediaPlayer1.FileName=s;
					//播放音乐
					axMediaPlayer1.Play();
					this.textBox1.Text=s;
 
					//获得歌曲信息
				    this.GetSongInfo(s);
				}
				catch
				{
					//出错警告
					MessageBox.Show("无法播放此文件","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
					//创建一个写文件流
					StreamWriter fWriter=new StreamWriter(this.filePath,true,System.Text.Encoding.Default);
					//将歌曲路径写入文件
					fWriter.WriteLine(s);
					//关闭文件流
                    fWriter.Close();

				}
				catch (DirectoryNotFoundException error)
				{
		        	//如果文件不存在则创建一个新文件，然后将歌曲路径写入文件
					File.Create(this.filePath);
					StreamWriter fWriter=new StreamWriter(this.filePath,true,System.Text.Encoding.Default);
					fWriter.WriteLine(s);
					fWriter.Close();
				}				
			}
		}

		private void listView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//如果有选中的歌曲就播放这首歌
			if (this.listView1.SelectedItems.Count!=0)
			{
				//获得歌曲的详细路径
				string fileName=this.listView1.SelectedItems[0].SubItems[3].Text;
				this.axMediaPlayer1.FileName=fileName;
				this.axMediaPlayer1.Play();
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//如果有选中的歌曲就播放这首歌
			if (this.listView1.SelectedItems.Count!=0)
			{
				//获得歌曲的详细路径
				this.axMediaPlayer1.FileName=this.listView1.SelectedItems[0].SubItems[3].Text;
				this.axMediaPlayer1.Play();
			}
		}


		private void button5_Click(object sender, System.EventArgs e)
		{
			//如果播放器正在放音乐，就停止播放
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
						//选定位置向前移动一格
						int pos=this.listView1.SelectedItems[0].Index-1;
						//当前选定的项取消
						this.listView1.SelectedItems[0].Selected=false;
						//设置新的选定项
						this.listView1.Items[pos].Selected=true;
 
						//播放当前选定项
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
						//选定位置向前移动一格
						int pos=this.listView1.SelectedItems[0].Index+1;
						//当前选定的项取消
						this.listView1.SelectedItems[0].Selected=false;
						//设置新的选定项
						this.listView1.Items[pos].Selected=true;
 
						//播放当前选定项
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
					//移除当前曲目
					this.listView1.SelectedItems[0].Remove();		
				}
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			//删除所有的曲目
			this.listView1.Items.Clear();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button8_Click(object sender, System.EventArgs e)
		{

			SaveFileDialog sDialog=new SaveFileDialog();
			//设置过滤器
			sDialog.Filter="歌曲列表文件(*.lst)|*.lst|所有文件(*.*)|*.*";
			if (sDialog.ShowDialog()==DialogResult.OK)
			{
			//得到保存文件名
			string fileName=sDialog.FileName;
			//创建写文件流
			StreamWriter sWriter=new StreamWriter(fileName,false,System.Text.Encoding.Default);
			//将列表中的歌曲逐一写入文件之中
			foreach (ListViewItem item in this.listView1.Items)
				{
			      sWriter.WriteLine(item.SubItems[3].Text);	
				}
			//关闭文件流
			sWriter.Close();
        	}	

		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog oDialog=new OpenFileDialog();
			//设置过滤器
			oDialog.Filter="歌曲列表文件(*.lst)|*.lst|所有文件(*.*)|*.*";
			if (oDialog.ShowDialog()==DialogResult.OK)
			{
				//得到加载的文件名
				string fileName=oDialog.FileName;
				//创建读文件流
				StreamReader sReader=new StreamReader(fileName,System.Text.Encoding.Default);
				//清空列表
				this.listView1.Items.Clear();
				//逐一将文件中的歌曲信息写入列表中
				string s=sReader.ReadLine();
				while (s!=null)
				{
				 this.GetSongInfo(s);
				 s= sReader.ReadLine();
				 
				}
				//关闭文件流
				sReader.Close();
			}	
		}


		private void button4_Click(object sender, System.EventArgs e)
		{
			//清空listView1
			this.listView1.Items.Clear();
			//载入收藏夹的歌曲列表
			this.LoadSongs();
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			Form2 form2=new Form2(this.filePath);
			//打开收藏夹编辑器
			form2.Show();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
		      
			//使用button1_Click的事件处理程序
			this.button1_Click(this,e);
		}
	}
}
