using System;
using System.Collections.Generic;

namespace _05.Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] tokens = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                Point upperLeft = new Point();
                string[] firstPoint = tokens[0].Split(':');
                upperLeft.X = int.Parse(firstPoint[0]);
                upperLeft.Y = int.Parse(firstPoint[1]);

                Point upperRight = new Point();
                string[] secondPoint = tokens[1].Split(':');
                upperRight.X = int.Parse(secondPoint[0]);
                upperRight.Y = int.Parse(secondPoint[1]);

                Point bottomLeft = new Point();
                string[] thirdPoint = tokens[2].Split(':');
                bottomLeft.X = int.Parse(thirdPoint[0]);
                bottomLeft.Y = int.Parse(thirdPoint[1]);

                Point bottomRight = new Point();
                string[] forthPoint = tokens[3].Split(':');
                bottomRight.X = int.Parse(forthPoint[0]);
                bottomRight.Y = int.Parse(forthPoint[1]);

                double width = Point.CalculateDistane(upperLeft, upperRight);
                double height = Point.CalculateDistane(upperLeft, bottomLeft);

                Box box = new Box();
                box.Width = (decimal)width;
                box.Heigth = (decimal)height;
                box.Perimeter = (decimal)(2 * (width + height));
                box.Area = (decimal)(width * height);
                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width:F0}, {box.Heigth:F0}");
                Console.WriteLine($"Perimeter: {box.Perimeter:F0}");
                Console.WriteLine($"Area: {box.Area:F0}");
            }
        }
    }

    class Box
    {
        public decimal Width { get; set; }
        public decimal Heigth { get; set; }
        public decimal Perimeter { get; set; }
        public decimal Area { get; set; }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double CalculateDistane(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Abs(firstPoint.X - secondPoint.X);
            double sideB = Math.Abs(firstPoint.Y - secondPoint.Y);
            double sideC = Math.Sqrt(sideA * sideA + sideB * sideB);

            return sideC;
        }
    }
}
