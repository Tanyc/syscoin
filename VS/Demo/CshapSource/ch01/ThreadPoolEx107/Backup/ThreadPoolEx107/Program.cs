using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadPoolEx107
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent are = new AutoResetEvent(false);
            RegisteredWaitHandle rwh = ThreadPool.RegisterWaitForSingleObject(
               are, new WaitOrTimerCallback(EventSignalled), null, -1, false);
            for (Int32 x = 0; x < 5; x++)
            {
                Thread.Sleep(5000);
                are.Set();
            }

            rwh.Unregister(null);
            Console.WriteLine("Hit Enter to terminate the sample");
            Console.ReadLine();
        }
        static void EventSignalled(Object state, Boolean timedOut)
        {
            if (timedOut)
            {
                Console.WriteLine("Timed-out while waiting for the AutoResetEvent.");
            }
            else
            {
                Console.WriteLine("The AutoResetEvent became signalled.");
            }
        }
    }
}
