using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split();

            for (int index = 0; index <= input.Length - 1; index++)
            {
                string word = input[index];

                if (!result.ContainsKey(word))
                {
                    result.Add(word, 1);
                }
                else
                {
                    result[word]++;
                }
            }

            foreach (var kvp in result.OrderByDescending(x => x.Value))
            {
                double percentage = (double)kvp.Value / input.Length *100;
                Console.WriteLine($"{kvp.Key} -> {kvp.Value} times ({percentage:f2}%)");
            }
        }
    }
}
