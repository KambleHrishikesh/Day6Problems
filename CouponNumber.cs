using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class CouponNumber
    {
        public int N;
        public static void Coupon(int N)
        {
            Console.WriteLine("Enter N Value");
            CouponNumber c = new CouponNumber();
            N = Convert.ToInt32(Console.ReadLine());
            CouponNumber.Coupon(N);

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(random.Next());
            }
        }
    }
}
