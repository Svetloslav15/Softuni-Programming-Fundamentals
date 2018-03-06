using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startIndex = 0;
            int currentLength = 1;
            int maxStart = 0;
            int maxLength = 1;

            for (int i = 1; i < nums.Length; i++)
            {           
                if (nums[i] > nums[i - 1])
                {
                    currentLength++;

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = startIndex;
                    }
                }
                else
                {
                    currentLength = 1;
                    startIndex = i;
                }
            }

            for (int index = maxStart; index < maxLength + maxStart; index++)
            {
                Console.Write(nums[index] + " ");
            }
            Console.WriteLine();
        }
    }
}
