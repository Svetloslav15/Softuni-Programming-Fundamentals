using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            for (int index = 0; index <= nums.Count - 1; index++)
            {
                nums[index] = Reversed(nums[index]);
                sum += nums[index];
            }

            Console.WriteLine(sum);
        }

        static int Reversed(int num)
        {
            int reversed = 0;
           while(num != 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }

            return reversed;
        }

        
    }
}
