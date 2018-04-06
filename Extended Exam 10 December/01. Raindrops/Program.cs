using System;
using System.Linq;

namespace _01._Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfRegions = double.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < amountOfRegions; i++)
            {
                double[] tokens = Console.ReadLine().Split().Select(double.Parse).ToArray();
                double raindropsCount = tokens[0];
                double squareMeters = tokens[1];

                sum += raindropsCount / squareMeters;
            }
            if (density > 0)
            {
                Console.WriteLine($"{sum / density:f3}");
            }
            else
            {
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
