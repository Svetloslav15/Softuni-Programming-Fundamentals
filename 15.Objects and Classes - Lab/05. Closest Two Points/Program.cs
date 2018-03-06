using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Closest_Two_Points
{ 
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
       

        public int Bottom
        {
            get
            {
                return Top + Height;                     
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
        class Program
        {
            static void Main()
            {
                Rectangle r1 = ReadRectangle();
                Rectangle r2 = ReadRectangle();

                Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
            }


        private static Rectangle ReadRectangle()
        {
            int[] coordinates = Console
                .ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            Rectangle rectangle = new Rectangle();
            rectangle.Top = coordinates[1];
            rectangle.Left = coordinates[0];
            rectangle.Width = coordinates[2];
            rectangle.Height = coordinates[3];

            return rectangle;
        }
        }
    }

}

