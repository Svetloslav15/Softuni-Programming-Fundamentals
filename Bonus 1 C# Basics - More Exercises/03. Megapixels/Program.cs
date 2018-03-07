using System;
using System.Linq;

namespace _03._Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double pixels = Math.Round(width * height / 1_000_000.0, 1);
            Console.WriteLine($"{width}x{height} => {pixels}MP");

        }
    }
}
