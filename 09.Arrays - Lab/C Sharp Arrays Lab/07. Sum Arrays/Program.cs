using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length = Math.Min(first.Length, second.Length);
            int length1 = Math.Max(first.Length, second.Length);
            int[] sum = new int[length1];

            for (int i = 0; i < length1; i++)
            {
                sum[i] = first[i % first.Length] + second[i % second.Length];

            }

            Console.WriteLine(string.Join(" ",sum));

        }
    }
}
