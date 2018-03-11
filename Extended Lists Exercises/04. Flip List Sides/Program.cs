using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (nums.Count % 2 != 0)
            {
                for (int index = 0; index < nums.Count / 2; index++)
                {
                    int x = nums[index + 1];
                    nums[index + 1] = nums[nums.Count - 2 - index];
                    nums[nums.Count - 2 - index] = x;
                }
            }
            else
            {
                for (int index = 0; index < nums.Count / 2 - 1; index++)
                {
                    int x = nums[index + 1];
                    nums[index + 1] = nums[nums.Count - 2 - index];
                    nums[nums.Count - 2 - index] = x;
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }

        
    }
}
