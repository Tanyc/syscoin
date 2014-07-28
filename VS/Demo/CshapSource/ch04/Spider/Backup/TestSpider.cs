using System;
using System.Windows.Forms;

//该 源 码 下载自www.aspx1.com(ａｓｐｘ１．ｃｏｍ)
namespace Spider
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class TestSpider
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.Run(new SpiderForm());
		}
	}
}
