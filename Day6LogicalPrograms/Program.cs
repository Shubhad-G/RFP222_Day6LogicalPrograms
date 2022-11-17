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
            Console.WriteLine("enter the option\n1. Fibonacci Series");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("enter a number");
                    int n=Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.fibonacciSeries(n);
                    break;
            }
            Console.ReadLine();
        }
    }
}
