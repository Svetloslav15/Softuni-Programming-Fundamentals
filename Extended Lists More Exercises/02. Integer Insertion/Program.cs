using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string num = Console.ReadLine();

            while (num != "end")
            {
                int position = num[0] - 48;
                nums.Insert(position, int.Parse(num));

                num = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
