using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (input != "Blaze it!")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string creature = tokens[0];
                string squadMate = tokens[1];

                if (!dict.ContainsKey(creature))
                { 
                    dict.Add(creature, new List<string>());
                }
                if (creature != squadMate && !dict[creature].Contains(squadMate))
                {
                    dict[creature].Add(squadMate);
                }

                input = Console.ReadLine();
            }
            foreach (var kvp in dict)
            {
                for (int index = 0; index <= kvp.Value.Count - 1; index++)
                {
                    string temp = kvp.Value[index];
                    if (dict.Keys.Contains(temp))
                    {
                        if (dict[temp].Contains(kvp.Key))
                        {
                            dict[temp].Remove(kvp.Key);
                            dict[kvp.Key].Remove(temp);
                        }
                    }
                }
            }
            
            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value.Count}");
            }

            
        }
    }
}
