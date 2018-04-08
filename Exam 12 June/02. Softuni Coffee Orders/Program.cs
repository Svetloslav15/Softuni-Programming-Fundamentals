using System;
using System.Globalization;

namespace _02._Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            decimal totalSum = 0;

            for (int order = 0; order < orders; order++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());
                decimal days = DateTime.DaysInMonth(date.Year, date.Month);
                decimal sum = (days * capsulesCount) * pricePerCapsule;
                totalSum += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
