using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)([<\|\/\\])(\w+)([<\|\/\\])([A-za-z]+)";
            string keyText = Console.ReadLine();
            Match match = Regex.Match(keyText, pattern);

            string start = match.Groups[1].Value;
            string end = match.Groups[5].Value;

            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            string secondPattern = $@"{start}(.*?){end}";

            MatchCollection matches = Regex.Matches(input, secondPattern);

            foreach (Match item in matches)
            {
                sb.Append(item.Groups[1].Value);
            }
            
            Console.WriteLine(sb.Length == 0? "Empty result" : sb.ToString());

        }
    }
}
