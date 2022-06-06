﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class SquareRoot
    {
        public static void Sqrt()
        {
            Console.WriteLine("Enter a number");
            int c = Convert.ToInt32(Console.ReadLine());
            double t = c;
            double epsilon = 1e-15;
            //check if number is negative
            if (t > 0)
            {
                //check condition till (t - c/t) becomes less then (epsilon * t)
                while (Math.Abs(t - c / t) > epsilon * t)
                {
                    //formula for square root
                    t = (t + c / t) / 2.0;
                }
                Console.WriteLine("Absolute square root is: " + t);
            }
            else
                Console.WriteLine("Enter positive number");
        }
    }
}
