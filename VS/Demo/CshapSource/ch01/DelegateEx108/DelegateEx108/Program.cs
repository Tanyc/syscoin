using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateEx108
{
    class Program
    {
        //步骤1： 声明一个委托
        public delegate void MyDelegate(string input);

        //步骤2:：定义各个方法，其参数形式和步骤1中声明的委托对的必须相同
        class MyClass1
        {
            public void delegateMethod1(string input)
            {
                Console.WriteLine("This is delegateMethod1 and the input to the method is {0}", input);
            }
            public void delegateMethod2(string input)
            {
                Console.WriteLine("This is delegateMethod2 and the input to the method is {0}", input);
            }
        }

        //步骤3：创建一个委托对象并将上面的方法包含其中
        class MyClass2
        {
            public MyDelegate createDelegate()
            {
                MyClass1 c2 = new MyClass1();
                MyDelegate d1 = new MyDelegate(c2.delegateMethod1);
                MyDelegate d2 = new MyDelegate(c2.delegateMethod2);
                MyDelegate d3 = d1 + d2;
                return d3;
            }
        }

        //步骤4：通过委托对象调用包含在其中的方法
        class MyClass3
        {
            public void callDelegate(MyDelegate d, string input)
            {
                d(input);
            }
        }

        static void Main(string[] args)
        {
            MyClass2 c2 = new MyClass2();
            MyDelegate d = c2.createDelegate();
            MyClass3 c3 = new MyClass3();
            c3.callDelegate(d, "Calling the delegate");
            Console.ReadLine();
        }
    }
}
