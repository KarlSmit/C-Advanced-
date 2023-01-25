using System;
using System.Diagnostics;

namespace Weekopdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch(); 
            sw.Restart();

            try
            {
                // Executing the program
                var executor = new Executor();
                executor.Start();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            long timeElapsed = sw.ElapsedMilliseconds; 
            Console.WriteLine($"De verwerkingstijd is: {timeElapsed} milliseconden");

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Program will exit now....");
            Console.ReadLine();
        }
    }
}
