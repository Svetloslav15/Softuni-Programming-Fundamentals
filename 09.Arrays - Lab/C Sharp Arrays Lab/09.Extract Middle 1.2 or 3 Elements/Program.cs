using System;
using System.Linq;

namespace _09.Extract_Middle_1._2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (nums.Length == 1)
            {
                Console.WriteLine("{ " +nums[0] + " }" );
            }
            else if (nums.Length % 2 == 0)
            {
                int[] result = new int[2];
                result[0] = nums[nums.Length / 2 - 1];
                result[1] = nums[nums.Length / 2];

                Console.WriteLine("{ " + result[0] + ", " + result[1] + " }");
            }
            else
            {
                int[] result = new int[3];
                result[1] = nums[nums.Length / 2 ];
                result[0] = nums[nums.Length / 2 - 1];
                result[2] = nums[nums.Length / 2 + 1];

                Console.WriteLine("{ " + result[0] + ", " + result[1] + ", " + result[2] + " }");
            }
        }
    }
}
