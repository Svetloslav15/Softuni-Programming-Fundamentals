using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int removedSum = 0;

            while (nums.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedElement = 0;
                if (index < 0)
                {
                    removedElement = nums[0];
                    nums.RemoveAt(0);
                    nums.Insert(0, nums[nums.Count - 1]);
                }
                else if (index > nums.Count - 1)
                {
                    removedElement = nums[nums.Count - 1];
                    nums.RemoveAt(nums.Count - 1);
                    nums.Add(nums[0]);
                }
                else
                {
                    removedElement = nums[index];
                    nums.RemoveAt(index);
                }
                removedSum += removedElement;

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] > removedElement)
                    {
                        nums[i] -= removedElement;
                    }
                    else
                    {
                        nums[i] += removedElement;
                    }
                }
            }
            Console.WriteLine(removedSum);
        }
    }
}
