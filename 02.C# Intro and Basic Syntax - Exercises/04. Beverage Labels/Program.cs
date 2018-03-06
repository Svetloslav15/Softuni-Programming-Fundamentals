using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            double allSugar = volume * sugar / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{volume * energy / 100.0}kcal, {allSugar}g sugars");
        }
    }
}
