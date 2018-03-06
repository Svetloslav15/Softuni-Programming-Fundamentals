using System;

namespace _12._Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
           
            double s = width * height;
            double p = 2 * width + 2 * height;
            double d = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(d);

        }
    }
}
