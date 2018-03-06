using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"([0-9x]*[A-F0-9]+)\b";

            var matches = Regex.Matches(inputText, pattern);

            string[] result = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
