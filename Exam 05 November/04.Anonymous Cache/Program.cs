using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> data = new Dictionary<string, Dictionary<string, decimal>>();
            Dictionary<string, Dictionary<string, decimal>> cache = new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();

            while (input != "thetinggoesskrra")
            {
                string[] tokens = input.Trim().Split(new char[] { '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    if (cache.ContainsKey(tokens[0]))
                    {
                        data.Add(tokens[0], new Dictionary<string, decimal>());
                        data[tokens[0]] = cache[tokens[0]];
                    }

                    if (!data.ContainsKey(tokens[0]))
                    {
                        data.Add(tokens[0], new Dictionary<string, decimal>());
                    }
                }
                else
                {
                    string dataKey = tokens[0].Trim();
                    decimal dataSize = decimal.Parse(tokens[1]);
                    string dataSet = tokens[2].Trim();

                    if (!data.ContainsKey(dataSet))
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, decimal>());
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                    }
                    else
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in data.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {kvp.Key}, Total Size: {kvp.Value.Values.Sum()}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }          
            }           
        }
    }
}
