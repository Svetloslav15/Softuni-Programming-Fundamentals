using System;
using System.Linq;

namespace _06._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] left = nums.Take(nums.Length / 4).Reverse().ToArray();
            int[] middle = nums.Skip(nums.Length / 4).Take(nums.Length / 2).ToArray();
            int[] right = nums.Skip(nums.Length / 4 + nums.Length / 2).Take(nums.Length / 4).Reverse().ToArray();
            left = left.Concat(right).ToArray();
            int[] sum = new int[nums.Length / 2];
            for (int index = 0; index < middle.Length; index++)
            {
                sum[index] = left[index] + middle[index];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
