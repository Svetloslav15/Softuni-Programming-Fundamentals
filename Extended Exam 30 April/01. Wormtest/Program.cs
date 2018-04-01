using System;

namespace _01._Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length = decimal.Parse(Console.ReadLine()) * 100;
            decimal width = decimal.Parse(Console.ReadLine());
            if (width == 0)
            {
                Console.WriteLine("{0:f2}",0);
                return;
            }

            decimal reminder = length % width;
            if (reminder == 0)
            {
                Console.WriteLine("{0:f2}", width * length);
                return;
            }
            if (reminder != 0)
            {
                Console.WriteLine("{0:f2}%", (decimal)length / width * 100);
            }
            
        }
    }
}
