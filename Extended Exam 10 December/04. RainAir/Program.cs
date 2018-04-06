using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            while (input != "I believe I can fly!")
            {
                string[] tokens = input.Split(new[] { "=", " "},StringSplitOptions.RemoveEmptyEntries);

                if (input.Contains("="))
                {
                    string firstName = tokens[0];
                    string secondName = tokens[1];
                    List<int> temp = new List<int>();
                    temp.AddRange(dict[secondName]);
                    dict[firstName] = temp;
                }
                else
                {
                    string name = tokens[0];
                    List<int> nums = new List<int>();

                    for (int index = 1; index < tokens.Length; index++)
                    {
                        nums.Add(int.Parse(tokens[index]));
                    }
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<int>());
                    }
                    dict[name].AddRange(nums);
                }
                input = Console.ReadLine();
            }

            foreach (var customer in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{customer.Key} ::: {string.Join(", ", customer.Value.OrderBy(x => x))}");
            }
        }
    }
}
