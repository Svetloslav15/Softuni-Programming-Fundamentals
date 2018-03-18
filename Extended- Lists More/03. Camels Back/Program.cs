using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Camels_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int camelBack = int.Parse(Console.ReadLine());

            int rounds = 0;

            while (nums.Count > camelBack)
            {
                nums.RemoveAt(0);
                nums.RemoveAt(nums.Count - 1);
                rounds++;
            }

            if (rounds == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", nums)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", nums)}");
            }
        }
    }
}
