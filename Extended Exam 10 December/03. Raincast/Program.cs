using System;
using System.Text.RegularExpressions;

namespace _03._Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string type = "";
            string source = "";
            string forecast = "";

            string typePattern = @"^(Type\:)\s(?<value>Normal|Warning|Danger)$";
            string sourcePattern = @"^(Source:\s)(?<value>[a-zA-Z0-9]+)$";
            string forecastPattern = @"^(Forecast:\s)(?<value>[^!,.?]+)$";

            int turn = 1;

            while (input != "Davai Emo")
            {
                Match typeMatch = Regex.Match(input, typePattern);
                Match sourceMatch = Regex.Match(input, sourcePattern);
                Match forecastMatch = Regex.Match(input, forecastPattern);

                if (typeMatch.Success && turn == 1)
                {
                    type = typeMatch.Groups["value"].Value;
                    turn = 2;
                }
                else if (sourceMatch.Success && turn == 2)
                {
                    source = sourceMatch.Groups["value"].Value;
                    turn = 3;
                }
                else if (forecastMatch.Success && turn == 3)
                {
                    forecast = forecastMatch.Groups["value"].Value;
                    Console.WriteLine($"({type}) {forecast} ~ {source}");
                    turn = 1;
                }
                input = Console.ReadLine();
            }
        }
    }
}
