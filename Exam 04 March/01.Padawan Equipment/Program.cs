using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            decimal priceOfLightSabers = decimal.Parse(Console.ReadLine());
            decimal priceOfRobes = decimal.Parse(Console.ReadLine());
            decimal priceOfBelts = decimal.Parse(Console.ReadLine());

            int freeBelts = numberOfStudents / 6;
            decimal allMoney = (priceOfLightSabers * Math.Ceiling(numberOfStudents + 0.1m * numberOfStudents)) + priceOfRobes * numberOfStudents + priceOfBelts * (numberOfStudents - freeBelts);

            if (allMoney <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {allMoney:F2}lv.");
            }
            else
            {
                decimal neededMoney = allMoney - amountOfMoney;
                Console.WriteLine($"Ivan Cho will need {neededMoney:F2}lv more.");
            }
        }
    }
}
