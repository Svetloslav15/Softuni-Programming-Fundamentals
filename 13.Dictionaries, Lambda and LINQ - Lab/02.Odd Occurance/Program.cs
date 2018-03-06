using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Occurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input
                .Split(' ')
                .ToArray();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();
            List<string> result = new List<string>();

            foreach (var word in words)
            {
                if (occurrences.ContainsKey(word))
                {
                    occurrences[word]++;
                }
                else
                {
                    occurrences[word] = 1;
                }
            }
            foreach (var item in occurrences)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ",result));

        }
        
    }
}
