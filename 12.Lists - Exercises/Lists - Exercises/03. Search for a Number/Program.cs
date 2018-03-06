using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int numsFrom = numbers[0];
            int numsHaveToTake = numbers[1];
            int searchFor = numbers[2];

            int counter = 0;
            for (int index = 0; index < numsFrom; index++)
            {
                if (counter < numsHaveToTake)
                {
                    nums.RemoveAt(index);
                    index--;
                    counter++;

                }
            }
            bool numsHave = false;

            foreach (var item in nums)
            {
                if (item == searchFor)
                {
                    numsHave = true;
                    break;
                }
            }

            if (numsHave)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
