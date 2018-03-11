using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Website> websites = new List<Website>();

            while (input != "end")
            {
                string[] tokens = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string host = tokens[0];
                string domain = tokens[1];

                if (tokens.Length == 2)
                {
                    Website website = new Website();
                    website.Host = host;
                    website.Domain = domain;
                    websites.Add(website);
                }
                else
                {
                    List<string> queries = tokens[2].Split(',').ToList();
                    Website website = new Website();
                    website.Host = host;
                    website.Domain = domain;
                    website.Queries = queries;
                    websites.Add(website);
                }

                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                if (website.Queries == null)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[",website.Queries)}]");
                }
            }
        
        }
    }
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }
}
