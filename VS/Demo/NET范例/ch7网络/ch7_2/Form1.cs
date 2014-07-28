using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Threading;
using System.Net.Sockets;
using System.IO;


namespace ch7_2
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.StatusBar statusBar1;
        
		//����������߳�
		private Thread listenThread;
		//���������״̬
		private bool listen=false;
        //������������Ķ���
		private TcpListener tcpListener;

		private System.Windows.Forms.RichTextBox richTextBox2;

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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(16, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(272, 40);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ŀ���ַ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 24);
			this.button1.TabIndex = 3;
			this.button1.Text = "׼������";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(190, 56);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "ֹͣ����";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "����������";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(224, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "����";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label1,
																					this.textBox1,
																					this.button1,
																					this.button2});
			this.groupBox1.Location = new System.Drawing.Point(16, 192);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 96);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 303);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(296, 22);
			this.statusBar1.TabIndex = 9;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(16, 88);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(272, 96);
			this.richTextBox2.TabIndex = 10;
			this.richTextBox2.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox2,
																		  this.statusBar1,
																		  this.groupBox1,
																		  this.button3,
																		  this.textBox2,
																		  this.label2,
																		  this.richTextBox1});
			this.Name = "Form1";
			this.Text = "��Ե�����";
			this.Closed += new System.EventHandler(this.Form1_Closed);
			this.groupBox1.ResumeLayout(false);
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
			//�ı䰴ť״̬
			button1.Enabled = false;
			button2.Enabled = true;
			//���������߳�
			listenThread = new Thread(new ThreadStart(StartListen));	
			//�����߳�
			listenThread.Start();
		}

		private void StartListen()
		{
			try
			{
				tcpListener = new TcpListener(5675);
				//��ʼ����
				tcpListener.Start();
				//�ı�״̬�� 
				statusBar1.Text = "���ڼ���...";
				//���ü���״̬
				this.listen=true;
                
				while(listen)
				{
//					//������������
//					Socket s = tcpListener.AcceptSocket();
//                    //����һ��������
//					Byte[] stream = new Byte[100];
//					int i=s.Receive(stream) ;
//					//����õ���ת��Ϊ�ַ�������
//					string message = System.Text.Encoding.UTF8.GetString(stream);
//					this.richTextBox2.AppendText(message);
					//��ȡTcpClient
					TcpClient s=tcpListener.AcceptTcpClient();
					NetworkStream nc=s.GetStream();
					byte[] bytes = new byte[1024];
					int bytesRead=nc.Read(bytes,0,bytes.Length);
					string message=System.Text.Encoding.Default.GetString(bytes,0,bytesRead);
					this.richTextBox2.AppendText(message);
				}
			}
			//������
			catch 
			{
				//���Դ�����
				//�ı�״̬��
				statusBar1.Text = "��ֹͣ������";
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		   //�ı䰴ť״̬
		   this.button1.Enabled=true;
		   this.button2.Enabled=false;
		   //�ı����״̬
		   this.listen=false;
		   //ֹͣ������
		   this.tcpListener.Stop();
		   //ֹͣ�����߳�
		   this.listenThread.Abort();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				//�����Ϣ
				string msg = "<"+this.textBox2.Text+">"+this.richTextBox1.Text+"\n";
				//����Ŀ��������ַ��������
				TcpClient tcpClient = new TcpClient(textBox1.Text, 5675);
				//�������������ʵ�������
				NetworkStream tcpStream = tcpClient.GetStream();

				StreamWriter streamW = new StreamWriter(tcpStream);
				//���ַ���д����
				streamW.Write(msg);
				//����������д�������
				streamW.Flush();
				//�ر�������
				tcpStream.Close();
				//�ر�
				tcpClient.Close();
 
				this.richTextBox2.AppendText(msg);
				this.richTextBox1.Clear();
			}
			catch
			{
			
				statusBar1.Text =  "Ŀ�������ܾ���������";
			}
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
			if (this.tcpListener!=null)
			{
				//�رռ�����
				this.tcpListener.Stop();
			}
			if (this.listenThread!=null)
			{
				//����̻߳���������״̬�͹ر���
				if (this.listenThread.ThreadState==ThreadState.Running)
				{
					this.listenThread.Abort();
				}
			}
		}
	}
}
