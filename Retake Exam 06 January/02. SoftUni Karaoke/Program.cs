using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Karaokee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> availableSongs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<string>> awards = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "dawn")
            {
                string[] tokens = command.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                string participant = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Any(x => x.Trim() == participant.Trim()) && availableSongs.Any(x => x.Trim() == song.Trim()))
                {
                    if (!awards.ContainsKey(participant))
                    {
                        awards.Add(participant, new List<string>());
                    }
                    if (!awards.Any(x => x.Value.Any(y => y == award)))
                    {
                        awards[participant].Add(award);
                    }
                }

                command = Console.ReadLine();
            }
          
            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var kvp in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");
                foreach (var award in kvp.Value)
                {
                    Console.WriteLine($"--{award.Trim()}");
                }
            }
        }
    }
}
