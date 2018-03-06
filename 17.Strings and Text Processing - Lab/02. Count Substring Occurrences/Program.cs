using System;
using System.Diagnostics;

namespace _02._Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int count = 0;
            int lastIndex = -1;

            while (true)
            {
                int index = input.IndexOf(word, lastIndex + 1);
                if (index != -1)
                {
                    count++;
                    lastIndex = index;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);

        }
    }
}
