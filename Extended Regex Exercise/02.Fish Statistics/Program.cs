using System;
using System.Text.RegularExpressions;

namespace _02.Fish_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<tail>[>]*)<(?<body>[(]+)(?<status>['\-x]{1})>{1}";

            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count != 0)
            {
                int counter = 1;
                foreach (Match fish in matches)
                {
                    string tail = fish.Groups["tail"].Value;
                    string body = fish.Groups["body"].Value;
                    string status = fish.Groups["status"].Value;

                    string tailStatus = CalculateTailStatus(tail);
                    string bosyStatus = CalculateBodyStatus(body);
                    string statusStatus = CalculateStatusStatus(status);


                    Console.WriteLine($"Fish {counter++}: {fish}");
                    if (tailStatus != "None")
                    {
                        Console.WriteLine($"  Tail type: {tailStatus} ({tail.Length * 2} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"  Tail type: {tailStatus} ");
                    }
                    Console.WriteLine($"  Body type: {bosyStatus} ({body.Length * 2} cm)");
                    Console.WriteLine($"  Status: {statusStatus} ");
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
        }

        static string CalculateStatusStatus(string status)
        {
            string stat = "";
            if (status == "'")
            {
                stat = "Awake";
            }
            else if (status == "-")
            {
                stat = "Asleep";
            }
            else if (status == "x")
            {
                stat = "Dead";
            }
            return stat;
        }

        static string CalculateBodyStatus(string body)
        {
            string bodyStatus = "";
            if (body.Length > 10)
            {
                bodyStatus = "Long";
            }
            else if (body.Length > 5)
            {
                bodyStatus = "Medium";
            }
            else
            {
                bodyStatus = "Short";
            }
            return bodyStatus;
        }

        static string CalculateTailStatus(string tail)
        {
            string tailStatus = "";
            if (tail.Length > 5)
            {
                tailStatus = "Long";
            }
            else if (tail.Length > 1)
            {
                tailStatus = "Medium";
            }
            else if (tail.Length == 1)
            {
                tailStatus = "Short";
            }
            else if (tail.Length == 0)
            {
                tailStatus = "None";
            }
            return tailStatus;
        }
    }

    
}
