using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] tokens = input.Split(" | ");
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];
                    if (!dict.ContainsKey(forceSide))
                    {
                        dict.Add(forceSide, new List<string>());
                    }
                    bool have = false;
                    foreach (var kvp in dict)
                    {
                        foreach (var item in kvp.Value)
                        {
                            if (item == forceUser)
                            {
                                have = true;
                                break;
                            }
                        }
                    }
                    if (have == false)
                    {
                        dict[forceSide].Add(forceUser);
                    }
                }
                else
                {
                    string[] tokens = input.Split(" -> ");
                    string forceSide = tokens[1];
                    string forceUser = tokens[0];
                    foreach (var kvp in dict)
                    {
                        foreach (var user in kvp.Value)
                        {
                            if (user == forceUser)
                            {
                                dict[kvp.Key].Remove(user);
                                break;
                            }
                        }
                    }
                    if (!dict.ContainsKey(forceSide))
                    {
                        dict.Add(forceSide, new List<string>());
                    }
                    dict[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                    foreach (var user in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
