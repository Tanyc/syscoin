using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ThreadPoolEx105
{
    class Program
    {

         // 存放要计算的数值的字段
         static double number1 = -1;
         static double number2 = -1;

        static void Main(string[] args)
        {
            // 获取线程池的最大线程数和维护的最小空闲线程数
            int maxThreadNum, portThreadNum;
            int minThreadNum;
            ThreadPool.GetMaxThreads(out maxThreadNum, out portThreadNum);
            ThreadPool.GetMinThreads(out minThreadNum, out portThreadNum);
            Console.WriteLine("最大线程数：{0}", maxThreadNum);
            Console.WriteLine("最小空闲线程数：{0}", minThreadNum);
   
            // 函数变量值
            int x = 2;
   
            // 启动第一个任务：计算x的8次方
            Console.WriteLine("启动第一个任务：计算{0}的8次方。", x);
            ThreadPool.QueueUserWorkItem(new WaitCallback(TaskProc1), x);
   
            // 启动第二个任务：计算x的8次方根
            Console.WriteLine("启动第二个任务：计算{0}的8次方根。", x);
            ThreadPool.QueueUserWorkItem(new WaitCallback(TaskProc2), x);
   
            // 等待，直到两个数值都完成计算
            while (number1 == -1 || number2 == -1) ;
   
            // 打印计算结果
            Console.WriteLine("y({0}) = {1}", x, number1 + number2);
            Console.ReadLine();
     
     }
   
     // 启动第一个任务：计算x的8次方
     static void TaskProc1(object o)
     {
         number1 = Math.Pow(Convert.ToDouble(o), 8);
     }
   
     // 启动第二个任务：计算x的8次方根
     static void TaskProc2(object o)
     {
         number2 = Math.Pow(Convert.ToDouble(o), 1.0 / 8.0);
     }


        
    }
}
