using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0} => {1}",nums[i],Math.Round(nums[i],MidpointRounding.AwayFromZero));
            }
        }
    }
}
