using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ch7_6
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(32, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(208, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "trueice.dhs.org";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(32, 152);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(152, 104);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "���";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 192);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "����";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "��������ַ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "ѡ�񱣴��ļ�";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(272, 245);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.label1,
																		  this.button2,
																		  this.button1,
																		  this.textBox2,
																		  this.textBox1});
			this.Name = "Form1";
			this.Text = "��ҳ����";
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
			SaveFileDialog sDialog=new SaveFileDialog();
			sDialog.Filter="��ҳ(*.htm;*.html)|*.htm;*.html";
			//��ʾ�����ļ��Ի���
			if (sDialog.ShowDialog()==DialogResult.OK)
			{
				//�õ������ļ���
				this.textBox2.Text=sDialog.FileName;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//�õ������ļ���
			string fileName=this.textBox2.Text.Trim();
			//�õ���ҳ����
			string url=this.textBox1.Text.Trim();
	   
			//���ǰ��û�м�"http://"��־����ϡ�
			if (url.IndexOf(@"http://")==-1 )
			{		
				url=@"http://"+url;
			}

			//����Web����
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			//�������󣬻�ȡ��Ӧ
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			//ʹ�õ��Ķ�д��
			Stream inStream = null;
			FileStream fileStream = null;
			try
			{
				//�����
				inStream = response.GetResponseStream();
				//����ļ�����
				long fileSizeInBytes = response.ContentLength;
				//�����ļ�������
				fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
				//��ȡ���ݻ��������Ⱥͻ�����
				int length = 1024;
				byte[] buffer = new byte[1025];
				//��¼��ȡ�ĳ���
				int bytesread = 0;
				string s="";
				//�������ȡ����
				while((bytesread = inStream.Read(buffer, 0, length)) > 0)
				{
					//������д���ļ�
					fileStream.Write(buffer, 0, bytesread);
					s+=System.Text.Encoding.Default.GetString(buffer,0,bytesread);
				}
			}
			catch(Exception fe)
			{
				MessageBox.Show("�ļ�����/д�����:"+fe.Message,"��ʾ��Ϣ",MessageBoxButtons.OK,MessageBoxIcon.Information); 
				
			}
			finally
			{
				//�ر���
				if(inStream != null)
				{
					inStream.Close();
				}
				if(fileStream != null)
				{
					fileStream.Close();
				}
			}

		}
	}
}
