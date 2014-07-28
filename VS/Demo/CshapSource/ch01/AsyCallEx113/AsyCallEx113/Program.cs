using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyCallEx113
{
    class Program
    {
        public delegate void AsyncEventHandler();

        class Class1
        {            
            public void Event1()
            {
                Console.WriteLine("Event1 Start");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Event1 End");
            }

            public void Event2()
            {
                Console.WriteLine("Event2 Start");
                int i = 1;
                while (i < 1000)
                {
                    i = i + 1;
                    Console.WriteLine("Event2 " + i.ToString());
                }
                Console.WriteLine("Event2 End");
            }

            public void CallbackMethod(IAsyncResult ar)
            {
                ((AsyncEventHandler)ar.AsyncState).EndInvoke(ar);
            }
        }
        static void Main(string[] args)
        {
            long start=0;
            long end=0;

            Class1 c = new Class1();
            Console.WriteLine("ready");
            start=DateTime.Now.Ticks;

            //AsyncEventHandler asy = new AsyncEventHandler(c.Event1);
            //IAsyncResult ia = asy.BeginInvoke(null, null);
            //c.Event2();
            //while (!ia.IsCompleted)
            //{
            //}
            //asy.EndInvoke(ia);
            //AsyncEventHandler asy = new AsyncEventHandler(c.Event1);
            //IAsyncResult ia = asy.BeginInvoke(null, null);
            //c.Event2();
            //ia.AsyncWaitHandle.WaitOne();
            AsyncEventHandler asy = new AsyncEventHandler(c.Event1);
            asy.BeginInvoke(new AsyncCallback(c.CallbackMethod), asy);
            c.Event2();

            //AsyncEventHandler asy = new AsyncEventHandler(c.Event1);
            //IAsyncResult ia=asy.BeginInvoke(null,null);
            //c.Event1();
            //c.Event2();
            //asy.EndInvoke(ia);
            
            end =DateTime.Now.Ticks;
            Console.WriteLine("时间刻度差="+ Convert.ToString(end-start) );
            Console.ReadLine();
        }
    }
}
