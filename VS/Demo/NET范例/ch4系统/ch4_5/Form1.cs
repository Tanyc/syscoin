using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Microsoft.Win32;
using System.IO;

namespace ch4_5
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "ȷ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("����", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(24, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 64);
			this.label1.TabIndex = 1;
			this.label1.Text = "���뿪�����Զ�����������壿";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(144, 128);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "ȡ��";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 213);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.label1,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "�Զ������Ĵ���";
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
		    //���ȷ����������Ϣд��ע���
			if (MessageBox.Show("��ȷ��������Ҫ�������������","��ʾ",MessageBoxButtons.OKCancel)==
				DialogResult.OK)
			{
				//����ļ��ĵ�ǰ·��
				string dir=Directory.GetCurrentDirectory();
				//��ȡ��ִ���ļ���ȫ��·��
				string exeDir=dir+"\\ch4_5.exe";

				//��ȡRun��
				RegistryKey key1=Registry.LocalMachine;
				RegistryKey key2=key1.CreateSubKey("SOFTWARE");
				RegistryKey key3=key2.CreateSubKey("Microsoft");
				RegistryKey key4=key3.CreateSubKey("Windows");
				RegistryKey key5=key4.CreateSubKey("CurrentVersion");
				RegistryKey key6=key5.CreateSubKey("Run");
				//��Run����д��һ���µļ�ֵ
				key6.SetValue("myForm",exeDir);
	
      		}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//���ȷ����������Ϣɾ��
			if (MessageBox.Show("��ȷ��Ҫɾ��ע����е���Ϣ��","��ʾ",MessageBoxButtons.OKCancel)==
				DialogResult.OK)
			{
			   	
				//��ȡRun��
				RegistryKey key1=Registry.LocalMachine;
				RegistryKey key2=key1.CreateSubKey("SOFTWARE");
				RegistryKey key3=key2.CreateSubKey("Microsoft");
				RegistryKey key4=key3.CreateSubKey("Windows");
				RegistryKey key5=key4.CreateSubKey("CurrentVersion");
				RegistryKey key6=key5.CreateSubKey("Run");
				//ɾ����ֵ
				key6.DeleteValue("myForm",false);
	
			}
		}
	}
}
