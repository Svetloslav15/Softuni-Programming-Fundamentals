using System;
using System.Linq;
using System.Numerics;

namespace _02._Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string number = input[1];
            int @base = int.Parse(input[0]);

            BigInteger result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                result += (number[number.Length - i - 1] - 48) * BigInteger.Pow(@base, i); 
            }

            Console.WriteLine(result);

        }
    }
}
