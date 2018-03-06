using System;
using System.Linq;

namespace _04._Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            double distance = CalculateDistane(firstPoint, secondPoint);

            Console.WriteLine($"{distance:F3}");
        }

        private static double CalculateDistane(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Abs(firstPoint.X - secondPoint.X);
            double sideB = Math.Abs(firstPoint.Y - secondPoint.Y);
            double sideC = Math.Sqrt(sideA * sideA + sideB * sideB);

            return sideC;
        }

        private static Point ReadPoint()
        {
            double[] a = Console
                .ReadLine()
                .Split(' ')
                .Select(c => double.Parse(c))
                .ToArray();

            Point point = new Point();
            point.X = a[0];
            point.Y = a[1]; 

            return point;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
