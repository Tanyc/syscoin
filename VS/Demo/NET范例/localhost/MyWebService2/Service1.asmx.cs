using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace MyWebService2
{
	public class Authentication:SoapHeader
	{
����public string Username;		
	public string Password;
 �� }
  
	/// <summary>
	/// Service1 ��ժҪ˵����
	/// </summary>


     public class Service1 : System.Web.Services.WebService
	
	{
		
		public Service1()
		{
			//CODEGEN���õ����� ASP.NET Web ����������������
			InitializeComponent();

		}

		#region Component Designer generated code
		
		//Web ����������������
		private IContainer components = null;
				
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion
		

		//�����û������֤�����header��
		public  Authentication header; 

		[WebMethod(Description="���Web���񷽷���Ҫ�ͻ��˷���һ�������û���֤��Soap��ͷ")]
		//�û������֤��Soapͷ
����    [SoapHeader("header",Required=true)]
		public string ValidateUser()
		{
			//�û������֤
			if ( header.Username=="zoujing" & header.Password=="zoujing") 
			{        ��
				return header.Username+ " ��ã�";
			}
			else
			{
				return "������û���";
			}	   			
		}
	}

	

}

