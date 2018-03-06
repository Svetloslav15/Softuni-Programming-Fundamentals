using System;
using System.Linq;
using System.Numerics;

namespace _01._Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger system = input[0];
            BigInteger number = input[1];
            string convertedNum = "";
            BigInteger convertedIndex = 0;

            while (number != 0)
            {
                convertedIndex = number % system;
                convertedNum += convertedIndex.ToString();
                number /= system;
            }
            Console.WriteLine(ReverseSt(convertedNum));
        }

        static string ReverseSt(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
