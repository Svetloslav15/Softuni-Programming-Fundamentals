using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Trim().Split(new char[] { '-', '>', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string key = tokens[0].Trim();

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<int>());
                }
                char temp = (tokens[1].ToCharArray())[0];
                if (char.IsDigit(temp))
                {
                    for (int index = 1; index <= tokens.Length - 1; index++)
                    {
                        int value = int.Parse(tokens[index]);
                        dict[key].Add(value);
                    }
                }
                else
                {
                    if (dict.Keys.Any(x => x.Trim() == tokens[1].Trim()))
                    {
                        for (int index = 0; index <= dict[tokens[1]].Count - 1; index++)
                        {
                            dict[key].Add(dict[tokens[1]][index]);
                        }
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var kvp in dict.Where(x => x.Value.Count != 0))
            {
                Console.WriteLine($"{kvp.Key} === {string.Join(", ",kvp.Value)}");
            }
        }
    }
}
