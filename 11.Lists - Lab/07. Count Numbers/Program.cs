using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums.Sort();
            nums.Add(int.MaxValue);

            int currentNum = nums[0];
            int counter = 1;

            for (int index = 1; index <= nums.Count - 1; index++)
            {
                if (currentNum == nums[index])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{currentNum} -> {counter}");
                    counter = 1;
                    currentNum = nums[index];
                }
            }
            
        }
    }
}
