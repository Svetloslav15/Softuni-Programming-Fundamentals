using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05._SoftUni_Messages
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string firstLine = Console.ReadLine();
                if (firstLine == "Decrypt!")
                {
                    return;
                }
                int number = int.Parse(Console.ReadLine());
                string pattern = @"^([0-9]+)(?<message>[A-Za-z]{" + $"{number}" + "})([^a-zA-Z]*)([0-9]+)([^a-zA-Z]*)$";

                Match match = Regex.Match(firstLine, pattern);

                if (match.Success)
                {
                    string message = match.Groups["message"].Value;
                    List<char> temp = new List<char>();
                    MatchCollection matches = Regex.Matches(firstLine, @"[0-9]");

                    foreach (Match num in matches)
                    {
                        int element = int.Parse(num.Value);
                        if (element >= 0 && element <= message.Length - 1)
                        {
                            temp.Add(message[element]);
                        }
                    }
                    Console.WriteLine($"{message} = {new string(temp.ToArray())}");
                }
            }
        }
    }
}
