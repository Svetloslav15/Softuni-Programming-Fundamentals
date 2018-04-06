using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int indexDonaldStep = nums[nums.Count - 1];
            nums.RemoveAt(nums.Count - 1);
            List<int> original = nums.Take(nums.Count).ToList();
            int steps = 0;
            
            while (true)
            {
                for (int index = 0; index < nums.Count; index++)
                {
                    nums[index]--;
                }

                if (nums[indexDonaldStep] == 0)
                {
                    Console.WriteLine(string.Join(" ", nums));
                    Console.WriteLine(steps);
                    return;
                }
                for (int index = 0; index < nums.Count; index++)
                {
                    if (nums[index] == 0)
                    {
                        nums[index] = original[index];
                    }
                }
                
                indexDonaldStep = int.Parse(Console.ReadLine());
                steps++;
            }
        }
    }
}
