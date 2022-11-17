using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void primeNumber(int n)
        {
            int prime=0;
            if (n == 1 || n == 0)
            {
                Console.WriteLine("{0} is not a prime number", n);
            }
            else if (n == 2)
            {
                Console.WriteLine("2 is a prime number");
            }
            else
            {
                for (int i = 3; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        prime = 1;
                    else
                        prime = 2;
                }
                if (prime == 1)
                    Console.WriteLine("{0} is not a prime number", n);
                else
                    Console.WriteLine("{0} is a prime number",n);
            }
        }
    }
}
