using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int index = 0; index <= nums.Count - 1; index++)
            {
                double currentNum = Math.Sqrt(nums[index]);

                if (currentNum == (int)currentNum)
                {
                    result.Add(nums[index]);
                }
            }
            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
