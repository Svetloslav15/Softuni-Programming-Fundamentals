using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputText, @"(^|(?<=\s))(\-*)\d+([.]\d+)*($|(?=\s))");

            string[] result = matches
               .Cast<Match>()
               .Select(x => x.Value)
               .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
