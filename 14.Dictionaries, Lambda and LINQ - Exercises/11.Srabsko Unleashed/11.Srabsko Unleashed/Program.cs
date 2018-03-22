using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11.Srabsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<singer>[A-Za-z]+[\s][A-Za-z]*\s?[A-Za-z]*\s?)@(?<venue>[A-Za-z]+[\s][A-Za-z]*\s?[A-Za-z]*)[\s]?(?<ticketPrice>[0-9]+)[\s](?<ticketsCount>[0-9]+)";

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            while (input != "End")
            {
                Match tokens = Regex.Match(input, pattern);
                if (tokens.Success)
                {
                    string singer = tokens.Groups["singer"].Value.Trim();
                    string venue = tokens.Groups["venue"].Value.Trim();
                    int ticketPrice = int.Parse(tokens.Groups["ticketPrice"].Value);
                    int ticketsCount = int.Parse(tokens.Groups["ticketsCount"].Value);

                    if (!dict.ContainsKey(venue))
                    {
                        dict.Add(venue, new Dictionary<string, int>());
                    }
                    if (!dict[venue].ContainsKey(singer))
                    {
                        dict[venue].Add(singer, 0);
                    }
                    dict[venue][singer] += ticketPrice * ticketsCount;
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
