using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class FibonacciSeries
    {
        public static void fibonacciSeries(int n)
        {
           int  firstNum=0,secondNum=1,sum=0;
            Console.WriteLine("{0},{1}\n",firstNum,secondNum);
            for(int i = 0; sum <n; i++)
            {
                sum=firstNum+secondNum;
                firstNum = secondNum;
                secondNum = sum;
                Console.Write(sum+",");
            }
        }
    }
}
