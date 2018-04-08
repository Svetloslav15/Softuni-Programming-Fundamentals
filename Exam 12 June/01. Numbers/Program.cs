using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new[] { " "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double average = nums.Average();
            nums = nums.Where(x => x > average).OrderByDescending(x => x).ToList();
            if (nums.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (nums.Count <= 5)
            {
                Console.WriteLine(string.Join(" ",nums));
            }
            else
            {
                Console.WriteLine(string.Join(" ",nums.Take(5)));
            }
        }
    }
}
