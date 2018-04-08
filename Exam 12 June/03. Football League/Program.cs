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
            string input = Console.ReadLine();

            string pattern = $@"{key}(?<firstTeam>.*?){key}.+?{key}(?<secondTeam>.*?){key}.+?(?<firstTeamScore>\d+):(?<secondTeamScore>\d+)";
            Dictionary<string, decimal> standing = new Dictionary<string, decimal>();
            Dictionary<string, decimal> mostGoals = new Dictionary<string, decimal>();

            while (input != "final")
            {
                Match match = Regex.Match(input, pattern);
                string firstTeam = match.Groups["firstTeam"].Value.ToUpper();
                firstTeam = ReverseString(firstTeam);
                string secondTeam = match.Groups["secondTeam"].Value.ToUpper();
                secondTeam = ReverseString(secondTeam);
                decimal firstTeamScore = decimal.Parse(match.Groups["firstTeamScore"].Value);
                decimal secondTeamScore = decimal.Parse(match.Groups["secondTeamScore"].Value);

                if (!standing.ContainsKey(firstTeam))
                {
                    standing.Add(firstTeam, 0);
                }
                if (!standing.ContainsKey(secondTeam))
                {
                    standing.Add(secondTeam, 0);
                }
                if (!mostGoals.ContainsKey(firstTeam))
                {
                    mostGoals.Add(firstTeam, 0);
                }
                if (!mostGoals.ContainsKey(secondTeam))
                {
                    mostGoals.Add(secondTeam, 0);
                }
                mostGoals[firstTeam] += firstTeamScore;
                mostGoals[secondTeam] += secondTeamScore;

                if (firstTeamScore > secondTeamScore)
                {
                    standing[firstTeam] += 3;
                }
                else if (secondTeamScore > firstTeamScore)
                {
                    standing[secondTeam] += 3;
                }
                else if (secondTeamScore == firstTeamScore)
                {
                    standing[firstTeam]++;
                    standing[secondTeam]++;
                }

                input = Console.ReadLine();
            }
            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var team in standing.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count++}. {team.Key} {team.Value}");
            }

            int n = 1;
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in mostGoals.OrderByDescending(x => x.Value).ThenBy(x =>x.Key))
            {
                if (n > 3)
                {
                    return;
                }
                Console.WriteLine($"- {team.Key} -> {team.Value}");
                n++;
            }
        }
        static string ReverseString(string text)
        {
            char[] temp = new char[text.Length];
            for (int i = 0; i <= text.Length - 1; i++)
            {
                temp[i] = text[text.Length - 1 - i];
            }
            return new string(temp);
        }
    }
}
