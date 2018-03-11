using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Remove_El_at_Odd_Pos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            string final = "";

            for (int index = 0; index <= input.Count - 1; index++)
            {
                if ((index + 1) % 2 == 0)
                {
                    final += input[index];
                }
            }
            Console.WriteLine(final);
        }
    }
}
