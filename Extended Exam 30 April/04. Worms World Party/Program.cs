using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<Worm>> worms = new Dictionary<string, List<Worm>>();

            while (input != "quit")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.None);
                string wormName = tokens[0];
                string teamName = tokens[1];
                long wormScore = long.Parse(tokens[2]);

                if (!worms.Values.Any(x => x.Any(y => y.Name == wormName)))
                {
                    if (!worms.ContainsKey(teamName))
                    {
                        worms.Add(teamName, new List<Worm>());
                    }
                    Worm worm = new Worm(wormName, wormScore);
                    if (!worms[teamName].Contains(worm))
                    {
                        worms[teamName].Add(worm);
                    }
                }

                input = Console.ReadLine();
            }
            int indexer = 1;
            foreach (var worm in worms.OrderByDescending(x => x.Value.Sum(y => y.Score)).ThenByDescending(x => x.Value.Sum(y => y.Score) / x.Value.Count))
            {
                Console.WriteLine($"{indexer++}. Team: {worm.Key} - {worm.Value.Sum(x => x.Score)}");
                foreach (var item in worm.Value.OrderByDescending(x => x.Score))
                {
                    Console.WriteLine($"###{item.Name} : {item.Score}");
                }
            }
        }
    }

    class Worm
    {
        public string Name { get; set; }
        public long Score { get; set; }

        public Worm(string name, long score)
        {
            Name = name;
            Score = score;
        }
    }
}
