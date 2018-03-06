using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            decimal time = hours * 3600 + minutes * 60 + seconds;
            decimal metresPerSecond = distance / time;
            decimal kilometresPerHour = metresPerSecond * 36 / 10;
            decimal milesPerHour = ((distance / 1609.0m) / time) * 36 / 10 * 1000;

            Console.WriteLine($"{metresPerSecond:f6}");
            Console.WriteLine($"{kilometresPerHour:f6}");
            Console.WriteLine($"{milesPerHour:f6}");

           
        }
    }
}
