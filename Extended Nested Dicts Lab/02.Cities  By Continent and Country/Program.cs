using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Cities__By_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfContinents = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int contNum = 1; contNum <= numberOfContinents; contNum++)
            {
                string[] tokens = Console.ReadLine().Split();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(city);
            }

            foreach (var kvp in continents)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var country in kvp.Value)
                {
                    Console.WriteLine($" {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
