using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class ReverseNumber
    {
        public static void ReverseTheNumber()
        {
            int n, reverse = 0, rem = 0;
            Console.WriteLine("Enter a Number ");
            n=Convert.ToInt32(Console.ReadLine());  

            while(n!=0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n/=10;
            }
            Console.WriteLine("Reversed Number: " + reverse);
        }
    }
}
