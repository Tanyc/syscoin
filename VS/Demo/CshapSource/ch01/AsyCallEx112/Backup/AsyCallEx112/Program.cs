using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyCallEx112
{
    class Program
    {        
        public delegate int sum(int a, int b);//定义一个执行加法的委托
        
        public class number
        {
            public int m = 4;            
            public int numberAdd(int a, int b)  //定义一个实现此委托签名的方法
            {
                int c = a + b;
                return c;
            }
            //定义一个与.net framework定义的AsyncCallback委托相对应的回调方法
            public void CallbackMethod2(IAsyncResult ar2)
            {
                sum s = (sum)ar2.AsyncState;
                int number = s.EndInvoke(ar2);
                m = number;
            }
        }
        static void Main(string[] args)
        {
            number num = new number();
            sum numberadd = new sum(num.numberAdd);
            AsyncCallback numberback = new AsyncCallback(num.CallbackMethod2);
            numberadd.BeginInvoke(55, 33, numberback, numberadd);
            Console.WriteLine("The sum is:");
            Console.WriteLine(num.m);
            Console.ReadLine();

        }
    }
}
