using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void perfectNumber(int n)
        {
            int devisorSum=0;
            for(int i=1;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    devisorSum+=i;
                }
            }
            if (devisorSum == n)
                Console.WriteLine("{0} is a perfect number",n);
            else
                Console.WriteLine("{0} is not a perfect numbber",n);
        }
    }
}
