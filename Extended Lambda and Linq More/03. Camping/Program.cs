using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string name = tokens[0];
                string camperModel = tokens[1];
                int timeToStay = int.Parse(tokens[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<string, int>());
                }
                dict[name].Add(camperModel, timeToStay);

                command = Console.ReadLine();
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key.Length))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"***{item.Key}");
                }
                Console.WriteLine($"Total stay: {kvp.Value.Values.Sum()}");
            }
        }
    }
}
