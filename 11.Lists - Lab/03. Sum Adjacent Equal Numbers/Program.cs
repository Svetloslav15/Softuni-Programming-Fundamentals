using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int index = 0; index <= nums.Count - 1; index++)
            {
                if (index + 1 <= nums.Count - 1)
                {
                    if (nums[index] == nums[index + 1])
                    {
                        nums[index] += nums[index + 1];
                        nums.RemoveAt(index + 1);
                        index = -1;
                    }
                }
            }

            Console.WriteLine(String.Join(" ",nums));

            //TODO 90/100
        }
    }
}
