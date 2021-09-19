using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace LogicalPrograms
{
    class StopWatch
    {
        public  void Timer()
        {
            Console.WriteLine("Stopwatch is running....");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            timer.Stop();
            Console.WriteLine(" Time elapsed: {0} ", timer.Elapsed);
        }
    }
}
