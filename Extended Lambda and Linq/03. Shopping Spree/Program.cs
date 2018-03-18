using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();
                string product = tokens[0];
                decimal productPrice = decimal.Parse(tokens[1]);
                
                if (!dict.ContainsKey(product))
                {
                    dict.Add(product, productPrice);
                }
                else
                {
                    if (dict[product] > productPrice)
                    {
                        dict[product] = productPrice;
                    }
                }

                input = Console.ReadLine();
            }

            decimal sumOfProducts = dict.Values.Sum();
            if (sumOfProducts > budget)
            {
              Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (var kvp in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{kvp.Key} costs {kvp.Value:F2}");
                }
            }
        }
    }
}
