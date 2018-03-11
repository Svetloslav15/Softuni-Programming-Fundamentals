using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            string pattern = $@"{key}";
            string valuePattern = $@"{value}";

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
 
            for (int line = 1; line <= numberOfLines; line++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '=', '>', ';' },StringSplitOptions.RemoveEmptyEntries);

                string dictKey = input[0];
                if (!dict.ContainsKey(dictKey))
                {
                    dict.Add(dictKey, new List<string>());
                }
                for (int index = 1; index <= input.Length - 1; index++)
                {
                    dict[dictKey].Add(input[index]);
                }
            }

            foreach (var kvp in dict)
            {
                if (Regex.IsMatch(kvp.Key, pattern))
                {
                    Console.WriteLine($"{kvp.Key.Trim()}:");
                    foreach (var item in kvp.Value)
                    {
                        if (Regex.IsMatch(item, valuePattern))
                        {
                            Console.WriteLine($"-{item.Trim()}");
                        }
                    }
                }
            }
        }
    }
}
