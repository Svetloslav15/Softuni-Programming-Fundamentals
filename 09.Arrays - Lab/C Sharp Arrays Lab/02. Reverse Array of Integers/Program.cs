using System;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
           
            for (int i = 0; i < n; i++)
            {
                array[n - i - 1] = int.Parse(Console.ReadLine());

            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
