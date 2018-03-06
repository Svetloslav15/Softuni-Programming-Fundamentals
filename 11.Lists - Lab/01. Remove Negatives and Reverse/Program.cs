using System;
using System.Linq;
using System.Collections.Generic;


namespace _01._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int index = 0; index <= nums.Count - 1; index++)
            {
                if (nums[index] < 0)
                {
                    nums.Remove(nums[index]);
                    index--;
                }
            }
            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            nums.Reverse();
            Console.WriteLine(String.Join(" ",nums));
        }
    }
}
