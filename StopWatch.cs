using System;
using System.Collections.Generic;
using System.Diagnostics;    //only used for stopwatch
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class StopWatch
    {
        public static void watch()
        {
            //Taking inbuild stop watch class 
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Press S to start the stop watch");
            string choice = Console.ReadLine();
            
            if (choice == "s")
            {
                stopWatch.Start();
            }
            Console.WriteLine("Press P to stop the watch");
            
            string select = Console.ReadLine();
            if (select == "p")
            {
                stopWatch.Stop();
            }
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // display the TimeSpan value.
            string elapsedTime = String.Format("{0}:{1}:{2}", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine("Run Time" + elapsedTime);
        }
    }
}
