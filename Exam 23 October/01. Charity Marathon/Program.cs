using System;

namespace _01._Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal days = decimal.Parse(Console.ReadLine());
            decimal numberOfRunners = decimal.Parse(Console.ReadLine());
            decimal averageNumberOfLabsPerRunner = decimal.Parse(Console.ReadLine());
            decimal trackLength = decimal.Parse(Console.ReadLine());
            decimal trackCapacity = decimal.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            decimal runners = 0;
            decimal allRunners = trackCapacity * days;
            if (numberOfRunners >= allRunners)
            {
                runners = allRunners;
            }
            else
            {
                runners = numberOfRunners;
            }
            

            decimal totalkilometers = (runners * averageNumberOfLabsPerRunner * trackLength) / 1000;

            Console.WriteLine("Money raised: {0:f2}", totalkilometers * moneyPerKilometer);
        }
    }
}
