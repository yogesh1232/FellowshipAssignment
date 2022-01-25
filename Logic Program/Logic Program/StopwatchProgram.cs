using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Program
{
    class StopwatchProgram
    {
        public static void GetStopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            // Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
