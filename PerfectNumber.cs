using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class PerfectNumber
    {
        public static void FindingThePerfectNumber() 
        {
            int n,i,sum,min,max;
            Console.WriteLine("Find perfect number in given number of range");
            Console.WriteLine("Input The starting range of numbers: ");
             min =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of number: ");
             max =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the perfect number within give range :");

            for (n=min;n<max;n++)
            {
                i = 1;
                sum = 0;
                while (i < n) 
                {
                    if (n % i == 0) 
                    {
                        sum = sum + i;
                        i++;
                    }
                    
                }
                if (sum == n)
                {
                    Console.Write("{0}", n);
                }
            }
        }
    }
}
