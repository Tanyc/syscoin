using System;
using System.Threading;

namespace ch9_7
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	class Class1
	{
		public  static HandleData data=new HandleData();
		
		public static void ThreadMethod1()
		{
	    Console.WriteLine("第一个工作线程开始执行");
        Console.WriteLine("第一个工作线程准备调用HandleData的WriteData方法");
		data.WriteData();
		Console.WriteLine("第一个工作线程返回");
		}
		
		public static void ThreadMethod2()
		{
			Console.WriteLine("第二个工作线程开始执行");
			Console.WriteLine("第二个工作线程准备调用HandleData的WriteData方法");
			data.WriteData();
			Console.WriteLine("第二个工作线程返回");
		}

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		
		[STAThread]
		static void Main(string[] args)
		{
			ThreadStart threadMethod1=new ThreadStart(ThreadMethod1);
			ThreadStart threadMethod2=new ThreadStart(ThreadMethod2);

			Console.WriteLine("现在开始创建并启动两个工作线程");
			Thread t1=new Thread(threadMethod1);
			Thread t2=new Thread(threadMethod2);
			t1.Start();
			t2.Start();
		}
	}

	class  HandleData
	{
		public  void  WriteData()
		{
//		Monitor.Enter(this);
//		Console.WriteLine(" WriteData method 被调用");
//		Console.WriteLine(" WriteData method 结束执行");
//		Monitor.Exit(this);
		lock(this)
		{
			Console.WriteLine(" WriteData method 被调用");
			Console.WriteLine(" WriteData method 结束执行");
		}
		}
	}

}
