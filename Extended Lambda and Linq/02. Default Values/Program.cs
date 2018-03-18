using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (input != "end")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string key = tokens[0];
                string value = tokens[1];
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, value);
                }
                else
                {
                    dict[key] = value;
                }

                input = Console.ReadLine();
            }
            string replacer = Console.ReadLine();

            var newDict = dict.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length).ToDictionary(x => x.Key, y => y.Value);
            var secDict = dict.Where(x => x.Value == "null").ToDictionary(x => x.Key, y => y.Value);
            
            foreach (var kvp in newDict)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
            foreach (var kvp in secDict)
            {
                Console.WriteLine($"{kvp.Key} <-> {replacer}");
            }
        }
    }
}
