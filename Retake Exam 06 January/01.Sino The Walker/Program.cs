using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            long numberOfSteps = long.Parse(Console.ReadLine());
            long secondsForOneStep = long.Parse(Console.ReadLine());

            long allSecond = time[0] * 3600 + time[1] * 60 + time[2] + numberOfSteps * secondsForOneStep;

            long hours = allSecond / 3600 % 24;
            long minutes = allSecond % 3600 / 60;
            long secunds = allSecond % 3600 % 60;

            Console.WriteLine($"Time Arrival: {hours:D2}:{minutes:d2}:{secunds:D2}");
        }
    }
}
