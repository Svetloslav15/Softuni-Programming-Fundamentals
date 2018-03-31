using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            char symbol = filter[0];
            int digit = (int)filter[1] - 48;

            string sentence = Console.ReadLine();
            List<string> wordsList = new List<string>();
            string pattern = @"^[A-Z].*([\.!?])$";

            while (sentence != "end")
            {
                Match match = Regex.Match(sentence, pattern);
                if (match.Success)
                {
                    MatchCollection words = Regex.Matches(sentence, @"\w+");
                    foreach (Match item in words)
                    {
                        int counter = 0;
                        for (int i = 0; i < item.Length; i++)
                        {
                            if (item.Value[i] == symbol)
                            {
                                counter++;
                            }
                        }
                        if (counter >= digit)
                        {
                            wordsList.Add(item.Value);
                        }
                    }
                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",wordsList));
        }
    }
}
