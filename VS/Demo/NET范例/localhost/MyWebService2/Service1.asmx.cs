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
　　public string Username;		
	public string Password;
 　 }
  
	/// <summary>
	/// Service1 的摘要说明。
	/// </summary>


     public class Service1 : System.Web.Services.WebService
	
	{
		
		public Service1()
		{
			//CODEGEN：该调用是 ASP.NET Web 服务设计器所必需的
			InitializeComponent();

		}

		#region Component Designer generated code
		
		//Web 服务设计器所必需的
		private IContainer components = null;
				
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// 清理所有正在使用的资源。
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
		

		//定义用户身份验证类变量header。
		public  Authentication header; 

		[WebMethod(Description="这个Web服务方法需要客户端发送一个用于用户认证的Soap标头")]
		//用户身份验证的Soap头
　　    [SoapHeader("header",Required=true)]
		public string ValidateUser()
		{
			//用户身份验证
			if ( header.Username=="zoujing" & header.Password=="zoujing") 
			{        　
				return header.Username+ " 你好！";
			}
			else
			{
				return "错误的用户名";
			}	   			
		}
	}

	

}

