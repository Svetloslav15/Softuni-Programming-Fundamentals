using System;

namespace _02._Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (profession == "Athlete")
            {
                Console.WriteLine($"The Athlete has to pay {quantity * 0.7:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine($"The {profession} has to pay {quantity * 1.00:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The SoftUni Student has to pay {quantity * 1.7:F2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {quantity * 1.2:F2}.");
            }
        }
    }
}
