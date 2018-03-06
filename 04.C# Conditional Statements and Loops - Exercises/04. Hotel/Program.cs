using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            byte nightsCount = byte.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;
           

            if (month == "May" || month == "October")
            {
                priceStudio = nightsCount * 50;
                priceDouble = nightsCount * 65;
                priceSuite = nightsCount * 75;
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = nightsCount * 60;
                priceDouble = nightsCount * 72;
                priceSuite = nightsCount * 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = nightsCount * 68;
                priceDouble = nightsCount * 77;
                priceSuite = nightsCount * 89;
            }
            
            if ((month == "May" && nightsCount > 7) || (month == "October" && nightsCount > 7))
            {
                priceStudio -= 0.05 * priceStudio;
            }
            if ((month == "June" && nightsCount > 14) || (month == "September" && nightsCount > 14))
            {
                priceDouble -= 0.10 * priceDouble;
            }
            if ((month == "July" && nightsCount > 14) || (month == "August" && nightsCount > 14) || (month == "December" && nightsCount > 14))
            {
                priceSuite -= 0.15 * priceSuite;
            }
            if (nightsCount > 7)
            {
                if (month == "September")
                {
                    priceStudio -= 60;
                }
                else if (month == "October")
                {
                    priceStudio -= 50;
                }
            }

            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
            Console.WriteLine($"Double: {priceDouble:F2} lv.");
            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
        }
        /* Дава 55/100 */ 

     }
}
