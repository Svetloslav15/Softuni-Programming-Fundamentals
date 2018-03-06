using System;

namespace _8._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            double length, width, height = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            height = double.Parse(Console.ReadLine());
            double v = (length + width + height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", v);


        }
    }
}
