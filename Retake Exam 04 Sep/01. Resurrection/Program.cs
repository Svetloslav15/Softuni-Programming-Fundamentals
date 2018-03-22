using System;

namespace _01._Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPhoenixes = int.Parse(Console.ReadLine());

            for (int n = 1; n <= numberOfPhoenixes; n++)
            {
                decimal bodyLength = decimal.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                decimal wingLength = decimal.Parse(Console.ReadLine());

                decimal years = (bodyLength * bodyLength) * (bodyWidth + 2 * wingLength);
                Console.WriteLine(years);
                      
            }
        }
    }
}
