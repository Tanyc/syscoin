using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ch1_4
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button1,
																					this.numericUpDown4,
																					this.numericUpDown3,
																					this.numericUpDown2,
																					this.label5,
																					this.label4,
																					this.label3,
																					this.label2,
																					this.numericUpDown1});
			this.groupBox1.Location = new System.Drawing.Point(24, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 256);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "���ô����С";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "����";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(232, 136);
			this.numericUpDown4.Maximum = new System.Decimal(new int[] {
																		   1000,
																		   0,
																		   0,
																		   0});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(40, 21);
			this.numericUpDown4.TabIndex = 8;
			this.numericUpDown4.Value = new System.Decimal(new int[] {
																		 300,
																		 0,
																		 0,
																		 0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(96, 136);
			this.numericUpDown3.Maximum = new System.Decimal(new int[] {
																		   1000,
																		   0,
																		   0,
																		   0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(40, 21);
			this.numericUpDown3.TabIndex = 7;
			this.numericUpDown3.Value = new System.Decimal(new int[] {
																		 300,
																		 0,
																		 0,
																		 0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(232, 56);
			this.numericUpDown2.Maximum = new System.Decimal(new int[] {
																		   1000,
																		   0,
																		   0,
																		   0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(40, 21);
			this.numericUpDown2.TabIndex = 6;
			this.numericUpDown2.Value = new System.Decimal(new int[] {
																		 300,
																		 0,
																		 0,
																		 0});
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(152, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "���߶�";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "��С�߶�";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(152, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "�����";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "��С���";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.numericUpDown1.Location = new System.Drawing.Point(96, 56);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   1000,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(40, 21);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 300,
																		 0,
																		 0,
																		 0});
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(360, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.Name = "Form1";
			this.Text = "���ô����С";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
			int widthmin=System.Decimal.ToInt32(numericUpDown1.Value);
			int heightmin=System.Decimal.ToInt32(numericUpDown3.Value);
            int widthmax=System.Decimal.ToInt32(numericUpDown2.Value);
			int heightmax=System.Decimal.ToInt32(numericUpDown4.Value);
			DialogResult dr,dr2;
			if (widthmin>widthmax)
			{
			    dr = MessageBox.Show("���õ���С��ȱ�����Ȼ��������ִ����ã�����Ŀ�Ƚ��̶�Ϊ�����",
					"����",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			    //���ݶԻ���ķ���ֵ���д��������Cancel��ֵ�����û�ԭ
				if (dr == DialogResult.OK)
				{
			    //û���κδ���
				}
				else if (dr==DialogResult.Cancel)
				{
				numericUpDown1.Value=300;
				numericUpDown2.Value=300;
              	}
			}
		    if (heightmin>heightmax)
			{
			    dr2 = MessageBox.Show("���õ���С�߶ȱ����߶Ȼ��������ִ����ã�����ĸ߶Ƚ��̶�Ϊ���߶�",
					"����",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			    //���ݶԻ���ķ���ֵ���д��������Cancel��ֵ�����û�ԭ
				if (dr2== DialogResult.OK)
				{
			    //û���κδ���
				}
				else if (dr2==DialogResult.Cancel)
				{
				numericUpDown3.Value=300;
				numericUpDown4.Value=300;
				}
			}
			widthmin=System.Decimal.ToInt32(numericUpDown1.Value);
		    heightmin=System.Decimal.ToInt32(numericUpDown3.Value);
			widthmax=System.Decimal.ToInt32(numericUpDown2.Value);
			heightmax=System.Decimal.ToInt32(numericUpDown4.Value);
			Size p1= new Size(widthmin,heightmin);
			Size p2= new Size(widthmax,heightmax);
			//���ô������С��Ⱥ���С�߶�
			this.MinimumSize=p1;
			//���ô��������Ⱥ����߶�
			this.MaximumSize=p2;		
		}
	}
}
