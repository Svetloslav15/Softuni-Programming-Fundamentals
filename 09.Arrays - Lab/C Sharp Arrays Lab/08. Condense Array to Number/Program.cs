using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = numbers.Length - 1;
            int[] modified = new int[length];

            for (int i = 1; i <= length; i++)
            {
                modified = new int[length - i];
                for (int index = 0; index <= modified.Length - 1; index++)
                {
                    modified[index] = numbers[index] + numbers[index + 1];
                }
                numbers = modified;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
