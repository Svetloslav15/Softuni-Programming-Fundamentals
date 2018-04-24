using System;

namespace _01._Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berrysPrice = decimal.Parse(Console.ReadLine());

            int sets = numberOfGuests / 6;
            if (numberOfGuests % 6 != 0)
            {
                sets++;
            }

            decimal finalPrice = sets * (2 * bananaPrice + 4 * eggsPrice + 0.2m * berrysPrice);
            if (finalPrice <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {finalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {finalPrice - amountOfCash:f2}lv more.");
            }
        }
    }
}
