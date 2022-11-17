using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("enter the option\n1. Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse a number\n5.Stop Watch");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("enter a number");
                    int n=Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.fibonacciSeries(n);
                    break;
                case 2:
                    Console.WriteLine("enter a number");
                    int perNum=Convert.ToInt32(Console.ReadLine());
                    PerfectNumber.perfectNumber(perNum);
                    break;
                case 3:
                    Console.WriteLine("enter a number");
                    int primeChk = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.primeNumber(primeChk);
                    break;
                case 4:
                    Console.WriteLine("enter a number");
                    int reverseNum=Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.reverseNumber(reverseNum);
                    break;
                case 5:
                    stopWatch.timer();
                    break;
            }
            Console.ReadLine();
        }
    }
}
