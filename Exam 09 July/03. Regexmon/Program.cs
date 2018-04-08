using System;
using System.Text.RegularExpressions;

namespace _03._Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string didimonPattern = @"[^a-zA-Z\-]+";
            string bojomonPattern = @"[a-zA-Z]+\-[a-zA-Z]+";
            int turner = 1;
            while (true)
            {
                if (turner % 2 != 0)
                {
                    Match match = Regex.Match(input, didimonPattern);
                    if (!match.Success)
                    {
                        return;
                    }
                    input = input.Substring(input.IndexOf(match.Value) + match.Value.Length);
                    Console.WriteLine(match.Value);
                }
                else
                {
                    Match match = Regex.Match(input, bojomonPattern);
                    if (!match.Success)
                    {
                        return;
                    }
                    input = input.Substring(input.IndexOf(match.Value) + match.Value.Length);
                    Console.WriteLine(match.Value);
                }
                turner++;
            }
        }
    }
}
