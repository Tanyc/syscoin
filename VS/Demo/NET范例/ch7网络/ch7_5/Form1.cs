using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ch7_5
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "��������ַ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(224, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(24, 120);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(224, 21);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "ѡ�񱣴��ļ�";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(176, 80);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "���";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(176, 168);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "����";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(280, 221);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.button1,
																		  this.label2,
																		  this.textBox2,
																		  this.textBox1,
																		  this.label1});
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
			if (this.textBox2.Text!="")
			{
				//�õ������ļ���
				string fileName=this.textBox2.Text.Trim();
				//�õ��˳�������
				string hostName=this.textBox1.Text.Trim();
				//�õ�������Ϣ 
				IPHostEntry ipInfo=Dns.GetHostByName(hostName); 
				//ȡ��IPAddress��ַ�б�
				IPAddress[] ipAddr=ipInfo.AddressList; 
				//�õ�ip 
				IPAddress ip=ipAddr[0]; 

				//��ϳ�Զ���ս�� 
				IPEndPoint hostEP=new IPEndPoint(ip,80);
				//����Socket ʵ�� 
				Socket socket=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp); 

				try 
				{ 
					//�������� 
					socket.Connect(hostEP); 
				} 
				catch(Exception se) 
				{ 
					MessageBox.Show("���Ӵ���"+se.Message,"��ʾ��Ϣ"
						,MessageBoxButtons.RetryCancel,MessageBoxIcon.Information); 
				} 

				//���͸�Զ���������������ݴ� 
				string sendStr="GET / HTTP/1.1\r\nHost: " + hostName + 
					"\r\nConnection: Close\r\n\r\n"; 
			
				//����bytes�ֽ�������ת�����ʹ� 
				byte[] bytesSendStr=new byte[1024]; 
				//�����������ַ���ת�����ֽ�byte���� 
				bytesSendStr=System.Text.Encoding.Default.GetBytes(sendStr); 
			
				try 
				{ 
					//�������������� 
    				socket.Send(bytesSendStr,bytesSendStr.Length,0); 
			
				} 
				catch(Exception ce) 
				{ 
					MessageBox.Show("���ʹ���:"+ce.Message,"��ʾ��Ϣ "
						,MessageBoxButtons.RetryCancel,MessageBoxIcon.Information); 
				} 


				//�������շ������ݵ��ַ��� 
				string receiveStr=""; 
				//�����ֽ����飬һ�ν������ݵĳ���Ϊ1024�ֽ� 
				byte[] receiveBytes=new byte[1024]; 
				//����ʵ�ʽ������ݵ��ֽ��� 
				int bytes=0; 
				//ѭ����ȡ��ֱ���������������� 
				while(true) 
				{ 
					bytes=socket.Receive(receiveBytes,receiveBytes.Length,0); 
					//��ȡ��ɺ��˳�ѭ�� 
					if(bytes<=0) 
						break; 
					//����ȡ���ֽ���ת��Ϊ�ַ��� 
					receiveStr+=System.Text.Encoding.Default.GetString(receiveBytes,0,bytes); 
				} 
				//������ȡ���ַ���ת��Ϊ�ֽ����� 
				string s=receiveStr.Substring(receiveStr.IndexOf("<"));
				byte[] content=System.Text.Encoding.Default.GetBytes(s); 

				try 
				{ 
					//�����ļ�������ʵ�� 
					FileStream fs=new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.ReadWrite); 
					//д���ļ� 
					fs.Write(content,0,content.Length); 
                    //����ɹ���ʾ
					MessageBox.Show("������ҳ�ɹ�","��ʾ��Ϣ",MessageBoxButtons.OK,MessageBoxIcon.Information); 
		
				} 
				catch(Exception fe) 
				{ 
					MessageBox.Show("�ļ�����/д�����:"+fe.Message,"��ʾ��Ϣ",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information); 
				}
  
				//����Socket 
				socket.Shutdown(SocketShutdown.Both); 
				//�ر�Socket 
				socket.Close(); 

			}
			else
			{
				MessageBox.Show("��������ַ","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information); 
		
			}
		}
	}
}
