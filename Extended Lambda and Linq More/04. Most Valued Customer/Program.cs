using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Most_Valued_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            Dictionary<string, List<string>> customers = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Shop is Open")
            {
                string[] tokens = input.Split();
                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, 0);
                }
                shop[product] = price;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Print")
            {
                if (input == "Discount")
                {
                    foreach (var item in shop)
                    {
                        shop[item.Key] -= 0.1m * shop[item.Key];
                    }
                }
                else
                {
                    string[] tokens = input.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    string customer = tokens[0];
                    List<string> productsList = tokens[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (!customers.ContainsKey(customer))
                    {
                        customers.Add(customer, new List<string>());
                    }
                    customers[customer].AddRange(productsList);

                    input = Console.ReadLine();
                }

                foreach (var item in collection)
                {

                }
            }
        }
    }
}