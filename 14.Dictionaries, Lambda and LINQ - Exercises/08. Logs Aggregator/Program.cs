using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var dictionary = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 1; i <= numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string ipAddress = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);

                if (!dictionary.ContainsKey(user))
                {
                    dictionary.Add(user, new SortedDictionary<string, int>());
                    dictionary[user][ipAddress] = duration;
                }
                else
                {
                    if (!dictionary[user].ContainsKey(ipAddress))
                    {
                        dictionary[user].Add(ipAddress, duration);
                    }
                    else
                    {
                        dictionary[user][ipAddress] += duration;
                    }
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.Write($"{kvp.Key}: {kvp.Value.Values.Sum()} ");
                Console.WriteLine($"[{string.Join(", ",kvp.Value.Keys)}]");             
            }
        }
    }
}
