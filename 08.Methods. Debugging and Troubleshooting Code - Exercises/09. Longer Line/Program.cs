using System;

namespace _09._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxDistance = double.MinValue;

            double maxx1 = 0.0;
            double maxy1 = 0.0;
            double maxx2 = 0.0;
            double maxy2 = 0.0;

            for (int i = 0; i < 2; i++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                double currentDistance = CalculateDistance(x1, y1, x2, y2);

                if (currentDistance > maxDistance)
                {
                    maxDistance = currentDistance;
                    maxx1 = x1;
                    maxy1 = y1;
                    maxx2 = x2;
                    maxy2 = y2;
                }
            }

            GetTheClosestPoint(maxx1, maxy1, maxx2, maxy2);

        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return distance;
        }

        static void GetTheClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1 * x1 + y1 * y1) <= Math.Abs(x2 * x2 + y2 * y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }


    }
}
