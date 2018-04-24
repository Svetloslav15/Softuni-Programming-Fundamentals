using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> drivers = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<double> nums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            List<int> indexes = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            foreach (var driver in drivers)
            {
                double fuel = 0;
                int pos = 0;
                bool finish = true;
                fuel += driver[0];
                for (int index = 0; index <= nums.Count - 1; index++)
                {
                    if (indexes.Contains(index))
                    {
                        fuel += nums[index];
                        pos++;
                    }
                    else
                    {
                        fuel -= nums[index];
                        if (fuel <= 0)
                        {
                            finish = false;
                            break;
                        }
                        pos++;
                    }
                }
                if (finish)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {pos}");
                }
            }
        }
    }
}
