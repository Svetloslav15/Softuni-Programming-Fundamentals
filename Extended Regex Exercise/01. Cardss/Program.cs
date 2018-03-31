using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Cardss
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<power>[\dAKQJ]+)(?<suit>[SHDC])";
            Regex regex = new Regex(pattern);

            List<string> list = new List<string>();

            MatchCollection matches = regex.Matches(input);

            foreach  (Match item in matches)
            {
                string power = item.Groups["power"].Value;
                string suit = item.Groups["suit"].Value;

                try
                {
                    int p = int.Parse(power);
                    if (p >= 2 && p <= 10)
                    {
                        string element = item.Groups["power"].Value + item.Groups["suit"].Value;
                        list.Add(element);
                    }
                }
                catch 
                {
                    if (power == "K" || power == "Q" || power == "J" || power == "A")
                    {
                        string element = item.Groups["power"].Value + item.Groups["suit"].Value;
                        list.Add(element);
                    }
                }
            }

            Console.WriteLine(string.Join(", ",list));
        }
    }
}
