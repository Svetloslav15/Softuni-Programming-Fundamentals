using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            
            while (input != "report")
            {
                string[] tokens = input.Split('|');
                string city = tokens[0];
                string country = tokens[1];
                int population = int.Parse(tokens[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);                      
                    }
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                }

                input = Console.ReadLine();
            }
            var orderedCountries = countries.OrderByDescending(c => c.Value.Values.Sum());
            foreach (var kvp in orderedCountries)
            {
                var orderedCities = kvp.Value.OrderByDescending(c => c.Value);
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value.Values.Sum()})");
                foreach (var vkp in orderedCities)
                {
                    Console.WriteLine($"=>{vkp.Key}: {vkp.Value}");
                }
            }
            
        }
    }
}
