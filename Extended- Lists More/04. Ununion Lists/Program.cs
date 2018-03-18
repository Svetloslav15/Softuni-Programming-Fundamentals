using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int line = 1; line <= numberOfLines; line++)
            {
                List<int> nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                for (int index = 0; index <= nums.Count - 1; index++)
                {
                    if (!primalList.Contains(nums[index]))
                    {
                        primalList.Add(nums[index]);
                        nums.RemoveAt(index);
                        index--;
                    }
                }
                for (int index = 0; index <= nums.Count - 1; index++)
                {
                    if (primalList.Contains(nums[index]))
                    {
                        primalList.Remove(nums[index]);
                        index--;
                    }
                }
            }
            primalList = primalList.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
