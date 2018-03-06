using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>\w{3})(\1)(?<year>\d{4})\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match data in matches)
            {
                var day = data.Groups["day"].Value;
                var month = data.Groups["month"].Value;
                var year = data.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

            

        }
    }
}
