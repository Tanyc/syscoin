using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;

namespace ch3_10
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ProgressBar progressBar1;
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
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "���Ҫ��ջ���վ��?";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 64);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "ȷ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar1.Location = new System.Drawing.Point(0, 102);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(248, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(248, 125);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.progressBar1,
																		  this.button1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "��ջ���վ";
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
			//��ȡ��������߼�������������
			string[] drivers=Directory.GetLogicalDrives();
			int i=drivers.Length;
            //��ʼ��processBar
			this.progressBar1.Value=0;
		    //�趨ProcessBar�Ĳ���
			this.progressBar1.Step=100/i;
            
			//��ÿ���߼��������ϵĻ���վ��Ҫ���
			foreach (string driver in drivers)
			{
				try
				{
					
					string[] sFiles=Directory.GetFiles(driver+"\\Recycled");
				    //������ջ���վ�µ������ļ�
					if (sFiles.Length!=0)
					{
						foreach (string sFile in sFiles)
						{
						File.Delete(sFile);
						} 
					}
                     
					string[] sDirectories=Directory.GetDirectories(driver+"\\Recycled");
					//��ջ���վ�µ�Ŀ¼
					if (sDirectories.Length!=0)
					{
						foreach (string sDirectory in sDirectories)
						{
						Directory.Delete(sDirectory,true);
						}
					
					}
					//processBar��ֵ����һ������
					this.progressBar1.PerformStep();

				}
				catch(Exception error)
				{
				//�������κε��¼�����
				}
			}		
			//�������н�����ProcessBarҲ����
	        this.progressBar1.Value=100;
		}

	}
}
