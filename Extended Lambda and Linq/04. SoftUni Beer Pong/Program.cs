using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Beer_Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            while (input != "stop the game")
            {
                string[] tokens = input.Split('|');
                string participant = tokens[0];
                string team = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!dict.ContainsKey(team))
                {
                    dict.Add(team, new Dictionary<string, int>());
                }
                if (dict[team].Count < 3)
                {
                    dict[team].Add(participant, points);
                }
                input = Console.ReadLine();
            }

            var final = dict.Where(x => x.Value.Count >= 3).OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);
            int indexer = 1;
            foreach (var kvp in final)
            {
                Console.WriteLine($"{indexer++}. {kvp.Key}; Players:");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{item.Key}: {item.Value}");
                }
            }

        }
    }
}
