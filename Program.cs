using System;
using System.Diagnostics;
using System.Threading;
class StopwatchProgram
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Start");
        stopwatch.Start();

        for (int i = 0; i < 2000; i++)
        {
            Thread.Sleep(30);
        }

        Console.WriteLine("Stop");
        stopwatch.Stop();

        Console.WriteLine("Time Elapsed : {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
    }
}