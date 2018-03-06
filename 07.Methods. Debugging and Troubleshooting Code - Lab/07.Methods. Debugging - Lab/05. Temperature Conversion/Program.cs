using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double degrees = ConvertDegrees(fahrenheit);
            Console.WriteLine($"{degrees:F2}");
        }

        static double ConvertDegrees(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
