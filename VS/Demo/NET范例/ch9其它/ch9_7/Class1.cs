using System;
using System.Threading;

namespace ch9_7
{
	/// <summary>
	/// Class1 ��ժҪ˵����
	/// </summary>
	class Class1
	{
		public  static HandleData data=new HandleData();
		
		public static void ThreadMethod1()
		{
	    Console.WriteLine("��һ�������߳̿�ʼִ��");
        Console.WriteLine("��һ�������߳�׼������HandleData��WriteData����");
		data.WriteData();
		Console.WriteLine("��һ�������̷߳���");
		}
		
		public static void ThreadMethod2()
		{
			Console.WriteLine("�ڶ��������߳̿�ʼִ��");
			Console.WriteLine("�ڶ��������߳�׼������HandleData��WriteData����");
			data.WriteData();
			Console.WriteLine("�ڶ��������̷߳���");
		}

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		
		[STAThread]
		static void Main(string[] args)
		{
			ThreadStart threadMethod1=new ThreadStart(ThreadMethod1);
			ThreadStart threadMethod2=new ThreadStart(ThreadMethod2);

			Console.WriteLine("���ڿ�ʼ�������������������߳�");
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
//		Console.WriteLine(" WriteData method ������");
//		Console.WriteLine(" WriteData method ����ִ��");
//		Monitor.Exit(this);
		lock(this)
		{
			Console.WriteLine(" WriteData method ������");
			Console.WriteLine(" WriteData method ����ִ��");
		}
		}
	}

}
