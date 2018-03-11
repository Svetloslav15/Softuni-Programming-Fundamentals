using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, HashSet<string>> dict = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                string[] tokens = input.Split(new[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = tokens[0];

                if (!dict.ContainsKey(topic))
                {
                    dict.Add(topic, new HashSet<string>());
                }
                string[] newArr = tokens.Skip(1).Take(tokens.Length - 1).ToArray();
                foreach (var item in newArr)
                {
                    dict[topic].Add($"#{item}");
                }

                input = Console.ReadLine();

            }

            string[] outPut = Console.ReadLine().Split(new[] { ", "},StringSplitOptions.RemoveEmptyEntries);

            foreach (var kvp in dict)
            {
                bool contains = true;
                foreach (var tag in outPut)
                {
                    if (!kvp.Value.Contains($"#{tag}"))
                    {
                        contains = false;
                    }
                }
                if (contains)
                {
                   
                    Console.WriteLine($"{kvp.Key} | {string.Join(", ",kvp.Value.Distinct())}");
                }
            }
        }
    }
}
