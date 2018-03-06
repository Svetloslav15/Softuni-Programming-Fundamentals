using System;
using System.Globalization;

namespace _01.Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime day = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(day.DayOfWeek);
        }
    }
}
