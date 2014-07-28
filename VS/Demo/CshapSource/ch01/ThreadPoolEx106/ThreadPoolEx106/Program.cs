using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadPoolEx106
{
    class Program
    {
        private static int x = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for status updates every 2 seconds.");
            Console.WriteLine("   (Hit Enter to terminate the sample)");
            Timer timer = new Timer(new TimerCallback(CheckStatus), x, 1,
                                    2000);
            Console.ReadLine();
        }
        static void CheckStatus(Object state)
        {
            Console.WriteLine("Checking Status." + (int)(state)++);
        }

    }
}
