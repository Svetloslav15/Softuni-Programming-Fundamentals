using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();

            for (int salesNumber = 1; salesNumber <= numberOfSales; salesNumber++)
            {
                Sale sale = ReadSale(); 
                if (!dict.ContainsKey(sale.Town))
                {
                    dict.Add(sale.Town, new List<decimal>());
                    dict[sale.Town].Add((decimal)sale.Quantity * sale.Price);
                }
                else
                {
                    dict[sale.Town].Add((decimal)sale.Quantity * sale.Price);
                }
            }

            foreach (var kvp in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Sum():F2}");
            }
        }
        
        private static Sale ReadSale()
        {
            string[] saleInfo = Console
                .ReadLine()
                .Split(' ');

            Sale sale = new Sale();

            sale.Town = saleInfo[0];
            sale.Product = saleInfo[1];
            sale.Price = decimal.Parse(saleInfo[2]);
            sale.Quantity = double.Parse(saleInfo[3]);

            return sale;
        }
    }
    
}
