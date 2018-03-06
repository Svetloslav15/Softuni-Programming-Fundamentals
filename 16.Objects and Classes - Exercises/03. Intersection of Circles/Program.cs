using System;
using System.Linq;

namespace _03._Intersection_of_Circles
{
    class Circle
    {
        public Point Center  { get; set; }
        public int Radious { get; set; }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    
    

    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleCoordinates = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] secondCircleCoordinates = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            Circle firstCircle = new Circle();
            Point firstPoint = new Point();
            firstPoint.X = firstCircleCoordinates[0];
            firstPoint.Y = firstCircleCoordinates[1];
            firstCircle.Center = firstPoint;
            firstCircle.Radious = firstCircleCoordinates[2];

            Circle secondCircle = new Circle();
            Point secondPoint = new Point();
            secondPoint.X = secondCircleCoordinates[0];
            secondPoint.Y = secondCircleCoordinates[1];
            secondCircle.Center = secondPoint;
            secondCircle.Radious = secondCircleCoordinates[2];

            double distance = CalculateDistanceBetweenCenters(firstPoint, secondPoint);

            Console.WriteLine(distance <= firstCircle.Radious + secondCircle.Radious ? "Yes" : "No");
        }

        private static double CalculateDistanceBetweenCenters(Point firstPoint, Point secondPoint)
        {
            double a = firstPoint.X - secondPoint.X;
            double b = firstPoint.Y - secondPoint.Y;
            double distance = Math.Sqrt(a * a + b * b);

            return distance;
        }
    }
}
