using System;
using System.Collections.Generic;

namespace _01.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int lines = 1; lines <= numberOfLines; lines++)
            {
                string[] tokens = Console.ReadLine().Trim().Split(new string[] { ",", "->"}, StringSplitOptions.RemoveEmptyEntries);
                string key = tokens[0];

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new Dictionary<string, int>());
                }

                for (int token = 1; token <= tokens.Length - 1; token++)
                {
                    string nestedKey = tokens[token].Trim();
                    if (!dict[key].ContainsKey(nestedKey))
                    {
                        dict[key].Add(nestedKey, 1);
                    }
                    else
                    {
                        dict[key][nestedKey]++;
                    }
                }
            }
            string[] foundItem = Console.ReadLine().Split();
            string itemColor = foundItem[0].Trim();
            string itemValue = foundItem[1].Trim();

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key.Trim()} clothes:");
                foreach (var valueN in kvp.Value)
                {
                    if (kvp.Key.Trim() == itemColor && valueN.Key.Trim() == itemValue)
                    {
                        Console.WriteLine($"* {valueN.Key.Trim()} - {valueN.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {valueN.Key.Trim()} - {valueN.Value}");
                    }
                }
            }
        }
    }
}
