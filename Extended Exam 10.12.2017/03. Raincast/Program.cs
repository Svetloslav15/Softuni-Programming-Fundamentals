using System;
using System.Text.RegularExpressions;

namespace _03._Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = 1;
            string type = "";
            string source = "";
            string forecast = "";

            string typePattern = @"(?<type>Type):\s(?<value>Normal|Danger|Warming)";
            string sourcePattern = @"(?<type>Source):\s(?<value>[a-zA-Z0-9]+)";
            string forecastPattern = @"^Forecast: ([^!.,?]+)$";

            while (input != "Davai Emo")
            {
                Match match = Regex.Match(input, sourcePattern);
                Match match2 = Regex.Match(input, typePattern);
                Match match3 = Regex.Match(input, forecastPattern);

                if (match2.Success)
                {
                    if (match2.Groups["type"].Value == "Type" && n == 1)
                    {
                        type = match2.Groups["value"].Value.Trim();
                        n = 2;
                    }
                }
                else if (match3.Success)
                {
                    if (match3.Groups["type"].Value == "Source" && n == 2)
                    {
                        source = match.Groups["value"].Value.Trim();
                        n = 3;
                    }
                }
                else if (match.Success)
                {
                    if (match.Groups["type"].Value == "Forecast" && n == 3)
                    {
                        forecast = match.Groups["value"].Value.Trim();
                        n = 1;
                        Console.WriteLine($"({type}) {forecast} ~ {source}");
                    }
                }
                else
                {
                    n = 1;
                }
                input = Console.ReadLine();
            }
        }
    }
}
