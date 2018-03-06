using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string pattern = @"([A-Za-z]+)(.*)(\1)";
            
            string replacersAsText = Console.ReadLine();
            string[] replacers = Regex.Split(replacersAsText, @"{(.+?)}").Where(x => x != "").ToArray();

            MatchCollection matches = Regex.Matches(inputText, pattern);

            int length = matches.Count;
            int indexer = 0;
            foreach (Match match in matches)
            {
                string newValue = match.Groups[1].Value + replacers[indexer++] + match.Groups[3].Value;
                inputText = inputText.Replace(match.Value, newValue);
            }

            Console.WriteLine(inputText);

        }


    }
}
