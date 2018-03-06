using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            

            if (type == "triangle")
            {
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());
                Console.WriteLine($"{TriangleArea(firstNum, secondNum):F2}");
            }
            else if (type == "square")
            {
                double firstNum = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"{SquareArea(firstNum):F2}");
            }
            else if (type == "rectangle")
            {
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());
                Console.WriteLine($"{RectangleArea(firstNum, secondNum):F2}");
            }
            else if (type == "circle")
            {
                double firstNum = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"{CircleArea(firstNum):F2}");
            }
        }

        static double CircleArea(double firstNum)
        {
            return Math.PI * firstNum * firstNum;
        }

        static double RectangleArea(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        static double SquareArea(double firstNum)
        {
            return firstNum * firstNum;
        }

        static double TriangleArea(double firstNum, double secondNum)
        {
            return firstNum * secondNum / 2;
        }
    }
}
