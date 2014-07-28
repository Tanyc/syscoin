using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
namespace ch1_13
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(80, 32);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(152, 21);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(32, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(264, 48);
			this.button1.TabIndex = 3;
			this.button1.Text = "��������ϵͳʱ�������";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.dateTimePicker1});
			this.groupBox1.Location = new System.Drawing.Point(32, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 80);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "��������";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.dateTimePicker2});
			this.groupBox2.Location = new System.Drawing.Point(32, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 80);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "����ʱ��";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker2.Location = new System.Drawing.Point(80, 32);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.ShowUpDown = true;
			this.dateTimePicker2.Size = new System.Drawing.Size(152, 21);
			this.dateTimePicker2.TabIndex = 0;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 333);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox2,
																		  this.groupBox1,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "ʱ������������";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
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
			
            DialogResult dr;
			dr=MessageBox.Show("��ȷ��Ҫ�ı�ϵͳʱ���������","��ʾ",MessageBoxButtons.OKCancel);
			//���ݶԻ��򷵻ص�ֵȷ���Ƿ�ı�ϵͳʱ�������
			if (dr==DialogResult.OK)
			{
				DateTime year=this.dateTimePicker1.Value;
				DateTime time=this.dateTimePicker2.Value;
				SystemTime  st=new SystemTime();
				LibWrapDateTime.GetSystemTime(st);
				//����ϵͳ����
				st.year=(ushort)year.Year;
				st.month=(ushort)year.Month;
				st.dayofweek=(ushort)year.DayOfWeek;
				st.day=(ushort)year.Day;
				//����ϵͳʱ��
				st.hour=(ushort)time.Hour;
				st.minute=(ushort)time.Minute;
				st.second=(ushort)time.Second;
				st.milliseconds=(ushort)time.Millisecond;
				LibWrapDateTime.SetSystemTime(st);
			}
			else if (dr==DialogResult.Cancel)
			{
			}
		}
		


		[ StructLayout( LayoutKind.Sequential )]
			public class SystemTime 
		{
			public ushort year; 
			public ushort month; 
			public ushort dayofweek; 
			public ushort day; 
			public ushort hour; 
			public ushort minute; 
			public ushort second; 
			public ushort milliseconds; 
		}

		public class LibWrapDateTime 
		{
			[ DllImport( "Kernel32.dll" )]
			public static extern void GetSystemTime( [In,Out] SystemTime st);
			[ DllImport( "Kernel32.dll" )]
			public static extern bool SetSystemTime( [In] SystemTime st);
		}
	}
}
