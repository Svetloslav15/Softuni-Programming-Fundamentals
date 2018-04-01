using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int steps = 0;
            for (int index = 0; index <= nums.Count - 1; index++)
            {
                if (nums[index] == 0)
                {
                    steps++;
                }
                else 
                {
                    steps++;
                    int temp = index;
                    index = nums[index];
                    nums[temp] = 0;
                }
            }
            Console.WriteLine(steps);
        }
    }
}
