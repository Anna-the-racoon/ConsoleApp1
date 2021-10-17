using System;

namespace ConsoleApp1
{
    public struct Result
    {
        public static string Convert(DateTime start, DateTime end)
        {
            var months = 12 * (end.Year - start.Year) + (end.Month - start.Month);

            var days = end.Day - start.Day;

            var years = months / 12;
            
            months -= years * 12;

            var experience = years <= 0 ? null : years + (years == 1 ? " year " : " years ");
            experience += months <= 0 ? null : months + (months == 1 ? " month " : " months ");
            experience += days <= 0 ? null : days + (days == 1 ? " day " : " days ");

            return experience;
        }
    }

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
