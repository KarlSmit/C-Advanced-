using System;
using Weekopdracht_4.Models;

namespace Weekopdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Executor which is the main processor of the application
            var executor = new Executor();
            executor.Start();
        }
    }
}
