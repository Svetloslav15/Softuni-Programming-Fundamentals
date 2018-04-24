using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);

            Dictionary<string, int> standing = new Dictionary<string, int>();
            Dictionary<string, int> goals = new Dictionary<string, int>();

            string input = Console.ReadLine();
            string pattern = $@"^.*(?<key>{key})(?<firstTeam>[a-zA-Z]+)({key}).*({key})(?<secondTeam>[a-zA-Z]+)({key}).*(?<firstScore>[0-9])\:(?<secondScore>[0-9])$";
            while (input != "final")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string firstTeam = match.Groups["firstTeam"].Value.ToUpper();
                    firstTeam = ReverseString(firstTeam);
                    string secondTeam = match.Groups["secondTeam"].Value.ToUpper();
                    secondTeam = ReverseString(secondTeam);
                    int firstTeamScore = int.Parse(match.Groups["firstScore"].Value);
                    int secondTeamScore = int.Parse(match.Groups["secondScore"].Value);
                    if (!standing.ContainsKey(firstTeam))
                    {
                        standing.Add(firstTeam, 0);
                    }
                    if (!standing.ContainsKey(secondTeam))
                    {
                        standing.Add(secondTeam, 0);
                    }
                    if (firstTeamScore > secondTeamScore)
                    {
                        standing[firstTeam] += 3;
                    }
                    else if (firstTeamScore < secondTeamScore)
                    {
                        standing[secondTeam] += 3;
                    }
                    else
                    {
                        standing[firstTeam]++;
                        standing[secondTeam]++;
                    }

                    if (!goals.ContainsKey(firstTeam))
                    {
                        goals.Add(firstTeam, 0);
                    }
                    if (!goals.ContainsKey(secondTeam))
                    {
                        goals.Add(secondTeam, 0);
                    }
                    goals[firstTeam] += firstTeamScore;
                    goals[secondTeam] += secondTeamScore;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            int indexer = 1;
            foreach (var team in standing.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{indexer++}. {team.Key} {team.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");
            int count = 0;
            foreach (var team in goals.OrderByDescending(x => x.Value))
            {
                if (count >= 3)
                {
                    return;
                }
                Console.WriteLine($"- {team.Key} -> {team.Value}");
                count++;
            }
        }

        private static string ReverseString(string text)
        {
            char[] temp = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                temp[i] = text[text.Length - 1 - i];
            }
            return new string(temp);
        }
    }
}
