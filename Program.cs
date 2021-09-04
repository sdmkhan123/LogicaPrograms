using System;
using System.Diagnostics;
namespace LogicaPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Please press any key to stop");
            Console.ReadKey();
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}