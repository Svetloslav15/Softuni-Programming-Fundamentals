using System;
using System.Text.RegularExpressions;

namespace _04_Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string happyPattern = @"(:\))|(;\))|(:D)|(:\*)|(:])|(;])|(;})|(:})|(\(:)|(\*:)|(c:)|(\[:)|(\[;)";
            string sadPattern = @"(:\()|(D:)|(;\()|(;\[)|(:\[)|(:\{)|(;\{)|(\):)|(:c)|(]:)|(];)";

            var happyMatches = Regex.Matches(input, happyPattern);
            int happyCount = happyMatches.Count;

            var sadMatches = Regex.Matches(input, sadPattern);
            int sadCount = sadMatches.Count;

            double index = happyCount / (double)sadCount;

            string emoji = "";
            if (index >= 2)
            {
                emoji = ":D";
            }
            else if (index > 1)
            {
                emoji = ":)";
            }
            else if (index == 1.00)
            {
                emoji = ":|";
            }
            else
            {
                emoji = ":(";
            }

            Console.WriteLine($"Happiness index: {index:F2} {emoji}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
