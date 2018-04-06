using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            string privateKey = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = @"^TO\:\s(?<recipient>[A-Z]+);\sMESSAGE\:\s(?<message>.+);$";
            var messages = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string message = match.Groups["message"].Value;
                    string sender = match.Groups["recipient"].Value;

                    if (!messages.ContainsKey(sender))
                    {
                        messages.Add(sender, new List<string>());
                    }
                    string cryptedMessage = "";
                    for (int index = 0; index <= input.Length - 1; index++)
                    {
                        char symbol = (char)(input[index] + privateKey[index % privateKey.Length] - 48);
                        cryptedMessage += symbol;
                    }
                    messages[sender].Add(cryptedMessage);
                }

                input = Console.ReadLine();
            }

            foreach (var sender in messages.OrderBy(x => x.Key))
            {
                foreach (var item in sender.Value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
