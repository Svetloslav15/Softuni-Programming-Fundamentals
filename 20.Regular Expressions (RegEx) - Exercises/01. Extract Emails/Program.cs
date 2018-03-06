using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(^|(?<=\s))([a-z0-9]+)([._-])?([a-z0-9]+)@([a-z0-9]+)([.-])?([a-z0-9]+)([.-])?([a-z0-9]*)\.([a-z0-9]+)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match email in matches)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
