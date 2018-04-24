using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<string>> awards = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "dawn")
            {
                string[] tokens = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                string participant = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!awards.ContainsKey(participant))
                    {
                        awards.Add(participant, new List<string>());
                    }
                    if (!awards[participant].Contains(award))
                    {
                        awards[participant].Add(award);
                    }
                }

                input = Console.ReadLine();
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var kvp in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");
                foreach (var award in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }

        }
    }
}
