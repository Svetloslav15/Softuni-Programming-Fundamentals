using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();
            while (command != "Aggregate")
            {
                string[] tokens = command.Split();
                string town = tokens[0];
                int shells = int.Parse(tokens[1]);

                if (!dict.ContainsKey(town))
                {
                    dict.Add(town, new List<int>());
                }
                if (!dict[town].Any(x => x == shells))
                {
                    dict[town].Add(shells);
                }
                command = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                int giantShell = kvp.Value.Sum() - ((kvp.Value.Sum() / kvp.Value.Count));
                Console.WriteLine($"{kvp.Key} -> {string.Join(", ",kvp.Value)} ({giantShell})");
            }
        }
    }
}
