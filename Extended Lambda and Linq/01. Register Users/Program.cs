using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01._Register_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, DateTime> dictionary = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                DateTime date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                dictionary.Add(user, date);
                input = Console.ReadLine();
            }

            foreach (var kvp in dictionary
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value))
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
