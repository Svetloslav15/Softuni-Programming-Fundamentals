using System;

namespace _04._Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int resolution1 = int.Parse(Console.ReadLine());
            int resolution2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{name:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:D2}/{year:d4} {hours:d2}:{minutes:D2}");
            if  (size >= 1_000_000)
            {
                Console.WriteLine($"Size: {size / 1_000_000.0}MB");
            }
            else if (size >= 1000)
            {
                Console.WriteLine($"Size: {size / 1000.0}KB");
            }
            else
            {
                Console.WriteLine($"Size: {size}B");
            }
            if (resolution1 > resolution2)
            {
                Console.WriteLine($"Resolution: {resolution1}x{resolution2} (landscape)");
            } 
            else if (resolution2 > resolution1)
            {
                Console.WriteLine($"Resolution: {resolution1}x{resolution2} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {resolution1}x{resolution2} (square)");
            }
        }
    }
}
