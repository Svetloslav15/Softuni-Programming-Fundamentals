using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' },StringSplitOptions.RemoveEmptyEntries);

            List<string> userNames = new List<string>();
            string pattern = @"^[A-Za-z][a-zA-z_0-9]{2,24}$";

            for (int index = 0; index < input.Length; index++)
            {
                Match match = Regex.Match(input[index], pattern);
                if (match.Success)
                {
                    userNames.Add(match.Value);
                }
            }
            string firstMax = "";
            string secondMax = "";
            int maxLength = int.MinValue;

            for (int index = 0; index <= userNames.Count - 1; index ++)
            {
                if (index + 1 <= userNames.Count - 1)
                {
                    string firstCurrent = userNames[index];
                    string secondCurrent = userNames[index + 1];
                    int currentLength = firstCurrent.Length + secondCurrent.Length;

                    if (currentLength > maxLength)
                    {
                        firstMax = firstCurrent;
                        secondMax = secondCurrent;
                        maxLength = currentLength;
                    }
                }
            }
            
            Console.WriteLine(firstMax);
            Console.WriteLine(secondMax);
        }
    }
}
