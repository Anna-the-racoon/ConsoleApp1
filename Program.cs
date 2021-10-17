using System;
using TimeSpanLlibrary;

namespace ConsoleResults
{
    public class Program
    {
        static void Main()
        {
            var start = new DateTime(2017, 03, 13);
            var end = DateTime.Now.Date;

            Console.WriteLine($"You work on Haval for {Result.Convert(start, end)}");

            Console.ReadKey();
        }
    }
}
