using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mAndN = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = mAndN[0];
            int n = mAndN[1];
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums = nums.Where(x => x >= 65 && x <= 90).Skip(m).Take(n).ToList();

            foreach (var item in nums)
            {
                Console.Write((char)item);
            }
        }
    }
}
