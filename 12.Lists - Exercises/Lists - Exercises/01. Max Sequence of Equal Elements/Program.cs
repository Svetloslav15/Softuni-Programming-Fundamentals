using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int currentStart = 0;
            int currentLength = 1;
            int maxStart = 0;
            int maxLength = 1;

            for (int index = 1; index <= nums.Count - 1; index++)
            {
                
                if (nums[currentStart] == nums[index])
                {
                    currentLength++;
                    
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = currentStart;
                        
                    }
                }
                else
                {
                    currentStart = index;
                    currentLength = 1;
                }

            }
            for (int index = maxStart; index < maxStart + maxLength; index++)
            {
                result.Add(nums[index]);
            }

            Console.WriteLine(String.Join(" ",result));
        }
    }
}
