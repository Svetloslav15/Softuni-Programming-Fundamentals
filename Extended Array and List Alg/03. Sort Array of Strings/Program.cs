using System;

namespace _03._Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            int length = input.Length;

            while (length != 0)
            {
                for (int index = 1; index <= length - 1; index++)
                {
                    if (input[index - 1].CompareTo(input[index]) > 0)
                    {
                        Swap(ref input[index - 1], ref input[index]);
                    }
                }
                length--;
            }

            Console.WriteLine(string.Join(" ",input));
        }

        static void Swap(ref string a, ref string b)
        {
            string x = a;
            a = b;
            b = x;
        }
    }
}
