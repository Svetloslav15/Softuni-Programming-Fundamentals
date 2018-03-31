using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Grocery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^(?<product>[A-Z][a-z]+)(?<delimiter>[:-])(?<price>[0-9]+\.[0-9]{2})$";
            var menu = new Dictionary<string, double>();

            while (input != "bill")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string product = match.Groups["product"].Value;
                    double price = double.Parse(match.Groups["price"].Value);

                    if (!menu.ContainsKey(product))
                    {
                        menu.Add(product, price);
                    }
                    else
                    {
                        menu[product] = price;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in menu.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} costs {kvp.Value:f2}");
            }
        }
    }
}
