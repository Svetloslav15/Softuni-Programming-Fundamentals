using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"[sStTaArR]";
            string planetPattern = @"@(?<planet>[A-Za-z]+)([^@\-!:>])*\:(?<population>[0-9]+)([^@\-!:>])*!(?<type>[AD])!([^@\-!:>])*\->(?<soldiers>[0-9]+)";
            for (int i = 0; i < numberOfMessages; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, pattern);
                int count = 0;
                foreach (Match item in matches)
                {
                    count++;
                }
                string message = Decrypt(count, input);
                Match match = Regex.Match(message, planetPattern);
                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    string type = match.Groups["type"].Value;
                    if (type == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var item in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }

        static string Decrypt(int count, string input)
        {
            char[] temp = new char[input.Length];

            for (int i = 0; i <= input.Length - 1; i++)
            {
                temp[i] = (char)(input[i] - count);
            }
            string finalString = new string(temp);

            return finalString;
        }
    }
}
