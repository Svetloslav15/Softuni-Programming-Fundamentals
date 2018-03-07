using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            decimal input = decimal.Parse(Console.ReadLine());

            if (type == "miles")
            {
                Console.WriteLine($"{input} miles = {input * 1.6m:F2} kilometers");
            }
            else if (type == "inches")
            {
                Console.WriteLine($"{input} inches = {input * 2.54m:f2} centimeters");
            }
            else if (type == "feet")
            {
                Console.WriteLine($"{input} feet = {input * 30m:F2} centimeters");
            }
            else if (type == "yards")
            {
                Console.WriteLine($"{input} yards = {input * 0.91m:F2} meters");
            }
            else if (type == "gallons")
            {
                Console.WriteLine($"{input} gallons = {input * 3.8m:F2} liters");
            }
        }
    }
}
