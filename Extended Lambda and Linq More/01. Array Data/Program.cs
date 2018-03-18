using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            double average = nums.Average();
            nums = nums.Where(x => x >= average).ToList();
            string command = Console.ReadLine();
            if (command == "Min")
            {
                Console.WriteLine(nums.Min());
            }
            else if (command == "Max")
            {
                Console.WriteLine(nums.Max());
            }
            else if (command == "All")
            {
                Console.WriteLine(string.Join(" ",nums.OrderBy(x => x)));
            }
        }
    }
}
