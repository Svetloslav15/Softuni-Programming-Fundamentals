using System;

namespace _01._Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInMiles = double.Parse(Console.ReadLine());
            double fuelTankCapInLiters = double.Parse(Console.ReadLine());
            double milesInHeavyWinds = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = distanceInMiles - milesInHeavyWinds;
            double nonHeavyConsumption = milesInNonHeavyWinds * 25;
            double heavyWindsConsumption = milesInHeavyWinds * (25 * 1.5);
            double fuelConsumption = nonHeavyConsumption + heavyWindsConsumption;
            double tolerance = fuelConsumption * 0.05;
            double totalFuelConsumption = fuelConsumption + tolerance;
            double remaining = fuelTankCapInLiters - totalFuelConsumption;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");

            if (remaining >= 0)
            {
                Console.WriteLine($"Enough with {remaining:F2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(remaining):f2}L more fuel.");
            }
        }
    }
}
