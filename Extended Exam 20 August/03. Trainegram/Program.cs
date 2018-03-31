using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^(?<locomotiv>\<\[([^a-zA-Z0-9])*\]\.)(?<wagon>\.\[([0-9a-zA-Z]*)\]\.)*$";

            while (input != "Traincode!")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
