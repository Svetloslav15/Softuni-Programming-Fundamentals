using System;
using System.Text.RegularExpressions;

namespace _03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            //surface
            string firstLine = Console.ReadLine();
            //mantle
            string secondLine = Console.ReadLine();
            //s|m|c|m|s
            string thirdLine = Console.ReadLine();
            //mantle 
            string forthLine = Console.ReadLine();
            //surface
            string fifthLine = Console.ReadLine();

            string surfacePattern = @"^[^a-zA-Z0-9]+$";
            string mantlePattern = @"^[0-9_]+$";
            string mixedPattern = @"^([^a-zA-Z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)(([^a-zA-Z0-9]+))$";

            if (Regex.IsMatch(firstLine, surfacePattern) &&
                Regex.IsMatch(secondLine, mantlePattern) &&
                Regex.IsMatch(thirdLine, mixedPattern) &&
                Regex.IsMatch(forthLine, mantlePattern) &&
                Regex.IsMatch(fifthLine, surfacePattern))
            {
                Console.WriteLine("Valid");
                Match match = Regex.Match(thirdLine, mixedPattern);
                string core = match.Groups[3].Value;
                Console.WriteLine(core.Length);
            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }
             //90/100
        }
    }
}
