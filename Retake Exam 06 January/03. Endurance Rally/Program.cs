using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split();
            List<double> indexes = Console.ReadLine().Split().Select(x => double.Parse(x)).ToList();
            double[] checkPointIndexes = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();

            for (int index = 0; index <= people.Length - 1; index++)
            {
                double fuel = 0.0;
                string currentName = "";
                currentName = people[index];
                fuel = currentName[0];
                for (int i = 0; i <= indexes.Count - 1; i++)
                {
                    if (checkPointIndexes.Any(x => x == i))
                    {
                        fuel += indexes[i];
                    }
                    else
                    {
                        fuel -= indexes[i];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{currentName} - reached {i}");
                        break;
                    }
                }
                if (fuel > 0)
                Console.WriteLine($"{currentName} - fuel left {fuel:F2}");
            }
        }
    }
}
