using System;

namespace _07._Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            decimal moneyLeft = budget;
            decimal allPrice = 0.0m;
            for (int i = 1; i <= numberOfItems; i++)
            {
                string item = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());
                int itemsCount = int.Parse(Console.ReadLine());
                if (itemsCount != 1)
                {
                    Console.WriteLine($"Adding {itemsCount} {item}s to cart.");
                }
                else 
                {
                    Console.WriteLine($"Adding {itemsCount} {item} to cart.");
                }
                allPrice += itemsCount * price;
                moneyLeft -= allPrice;
                if ((budget - allPrice) < 0)
                {
                    break;
                }
                
            }

            Console.WriteLine($"Subtotal: ${allPrice:F2}");
            if (allPrice <= budget)
            {
                Console.WriteLine($"Money left: ${budget - allPrice:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget - allPrice):f2} more.");
            }
        }
    }
}
