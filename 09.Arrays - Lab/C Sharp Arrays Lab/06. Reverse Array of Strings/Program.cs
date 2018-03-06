using System;
using System.Linq;

namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] reversed = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }

            Console.WriteLine(String.Join(" ",reversed));

        }
    }
}
