using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Loras_Fan_Club
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Make a decision already!")
            {
                string[] tokens = input.Split(' ');
                if (!tokens.Contains("does"))
                {
                    string name = tokens[0];
                    string trait = tokens[1];
                    int traitValue = int.Parse(tokens[2]);
                    if (trait == "Kind")
                    {
                        traitValue *= 2;
                    }
                    else if (trait == "Handsome")
                    {
                        traitValue *= 3;
                    }
                    else if (trait == "Smart")
                    {
                        traitValue *= 5;
                    }
                    else if (trait == "Greedy" || trait == "Rude" || trait == "Dumb")
                    {
                        traitValue *= -1;
                    }

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new Dictionary<string, int>());
                    }
                    if (!dict[name].ContainsKey(trait))
                    {
                        dict[name].Add(trait, traitValue);
                    }
                    else
                    {
                        if (dict[name][trait] < traitValue)
                        {
                            dict[name][trait] = traitValue;
                        }
                    }
                }
                else
                {
                    string name = tokens[0];
                    if (dict.ContainsKey(name))
                    {
                        foreach (var kvp in dict.Where(x => x.Key == name))
                        {
                            foreach (var item in kvp.Value)
                            {
                                if (dict[name][item.Key] >= 0)
                                {
                                    dict[name].Remove(item.Key);
                                    if (dict[name].Count == 0)
                                    {
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"# {kvp.Key}: {kvp.Value.Values.Sum()}");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"!!! {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
