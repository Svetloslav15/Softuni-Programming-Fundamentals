using System;

namespace _08._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            GetTheClosestPoint(x1, y1, x2, y2);
        }

        static void GetTheClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1 * x1 + y1 * y1) >= Math.Abs(x2 * x2 + y2 * y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
