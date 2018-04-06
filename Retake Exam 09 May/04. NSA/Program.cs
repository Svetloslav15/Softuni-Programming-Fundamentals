using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "quit")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string country = tokens[0];
                string spyName = tokens[1];
                int spyScore = int.Parse(tokens[2]);

                if (!dict.ContainsKey(country))
                {
                    dict.Add(country, new Dictionary<string, int>());
                }

                if (!dict[country].ContainsKey(spyName))
                {
                    dict[country].Add(spyName, spyScore);
                }
                else
                {
                    dict[country][spyName] = spyScore;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {kvp.Key}");
                foreach (var spy in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
