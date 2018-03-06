using System;

namespace _01._Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distanceAll = (wingFlaps / 1000) * distance;
            double after = wingFlaps / 100;
            double finalTime = (wingFlaps / endurance) * 5 + after;

            Console.WriteLine($"{distanceAll:f2} m.");
            Console.WriteLine($"{finalTime} s.");
        }
    }
}
