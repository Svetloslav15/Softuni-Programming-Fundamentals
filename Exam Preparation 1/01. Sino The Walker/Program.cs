using System;
using System.Globalization;
using System.Numerics;

namespace _01._Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long numberOfSteps = long.Parse(Console.ReadLine()) % 86400;
            long timeForEachSteps = long.Parse(Console.ReadLine()) % 86400;
            long all = numberOfSteps * timeForEachSteps;
            time = time.AddSeconds(all);

            Console.WriteLine($"Time Arrival:{time: HH:mm:ss}");
        }
    }
}
