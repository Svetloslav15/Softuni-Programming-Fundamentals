using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = null;
            double price = 0.0;
            double discount = 0.0;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500.0;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000.0;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500.0;
            }

            if (package == "Normal")
            {
                price += 500;
                discount = price - 0.05 * price;
            }
            else if (package == "Gold")
            {
                price += 750;
                discount = price - 0.1 * price;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                discount = price - 0.15 * price;
            }
            var pricePerPerson = discount / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            



        }
    }
}
