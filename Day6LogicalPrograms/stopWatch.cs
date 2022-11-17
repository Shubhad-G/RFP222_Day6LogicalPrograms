using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class stopWatch
    {
        public static void timer()
        {
            Stopwatch sw = Stopwatch.StartNew();
            int tVal = 0;
            Console.WriteLine("enter 2 to start the timer");
            int start = Convert.ToInt32(Console.ReadLine());
            while(start==2)
            {
                sw.Start();
                tVal++;
                Console.WriteLine("enter 0 to stop the clock");
                Console.ReadLine();
                sw.Stop();
                break;
            }
            Console.WriteLine("Elapsed Time :{0}",sw.Elapsed);
        }

    }
}
