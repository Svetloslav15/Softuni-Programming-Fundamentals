using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] days =
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(days[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(String.Join(Environment.NewLine, days));
            }
        }
    }
}
