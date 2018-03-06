using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            byte numberOfRotates = byte.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];
            int[] currentArray = new int[nums.Length];
            int[] tempArray = new int[nums.Length];

            for (int i = 1; i <= numberOfRotates; i++)
            {
                if (i == 1)
                {
                    currentArray[0] = nums[nums.Length - 1];
                    for (int pos = 1; pos < nums.Length; pos++)
                    {
                        currentArray[pos] = nums[pos - 1];
                    }
                }
                else
                {
                    currentArray[0] = tempArray[nums.Length - 1];
                    for (int pos = 1; pos < nums.Length; pos++)
                    {
                        currentArray[pos] = tempArray[pos - 1];
                    }
                }

                for (int j = 0; j < nums.Length; j++)
                {
                    tempArray[j] = currentArray[j];
                }

                for (int index = 0; index < nums.Length; index++)
                {
                    sum[index] += tempArray[index];
                }
            }

            Console.WriteLine(string.Join(" ", sum));

        }



    }
}

