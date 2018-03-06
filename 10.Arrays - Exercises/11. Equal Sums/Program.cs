using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool have = false;

            int pos = 0;
            if (numbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            for (int index = 0; index <= numbers.Length - 1; index++)
            {
                int currentNum = numbers[index];

                for (int i = 0; i < index; i++)
                {
                    leftSum += numbers[i];
                }

                for (int i = index + 1; i <= numbers.Length - 1; i++)
                {
                    if (i <= numbers.Length - 1)
                    {
                        rightSum += numbers[i];
                    }
                }

                if (leftSum == rightSum)
                {
                    pos = index;
                    have = true;
                    break;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
            if (have)
            {
                Console.WriteLine(pos);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
