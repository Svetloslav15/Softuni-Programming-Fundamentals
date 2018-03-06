using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] leftSide = new int[numbers.Length / 4];
            int[] rightSide = new int[numbers.Length / 4];
            int[] middleSide = new int[numbers.Length / 2];
            int[] sum = new int[numbers.Length / 2];
            int counter = 0;

            int[] first = new int[numbers.Length / 2];
            

            for (int index = 0; index <= numbers.Length - 1; index++)
            {
                if (index < numbers.Length / 4)
                {
                    leftSide[index] = numbers[index];
                    rightSide[index] = numbers[numbers.Length - 1 - index];
                }
                else if (index >= numbers.Length / 4 && counter < numbers.Length / 2)
                {
                    middleSide[index - (numbers.Length / 4)] = numbers[index];
                    counter++;
                }
            }
            leftSide = ReverseArray(leftSide);

            for (int index = 0; index < leftSide.Length; index++)
            {
                first[index] = leftSide[index];
                first[index + (middleSide.Length / 2)] = rightSide[index];
                
            }

            for (int index = 0; index <= numbers.Length / 2 - 1; index++)
            {
                sum[index] = first[index] + middleSide[index];
            }

            Console.WriteLine(string.Join(" ",sum));
            

        }

        static int[] ReverseArray(int[] leftSide)
        {
            int[] reversed = new int[leftSide.Length];

            for (int i = 0; i < leftSide.Length; i++)
            {
                reversed[i] = leftSide[leftSide.Length - 1 - i];
            }
            return reversed;
        }
    }
}
