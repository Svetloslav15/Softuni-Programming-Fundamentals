using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07._Booming_Cannon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int distance = arr[0];
            int elementsCount = arr[1];

            List<string> destoyed = new List<string>();

            string input = Console.ReadLine();
            string pattern = @"(?<=\\<<<)(?<target>.+?)(?=\\<<<|$)";

            var matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match item in matches)
                {
                    char[] element = item.Groups["target"].Value.Skip(distance).Take(elementsCount).ToArray();
                    string el = new string(element);
                    destoyed.Add(el);
                }
            }

            Console.WriteLine(string.Join("/\\",destoyed.Where(x => x != "").ToList()));
        }
    }
}
