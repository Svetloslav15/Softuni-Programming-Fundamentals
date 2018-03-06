using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if (type == "face")
            {
                Console.WriteLine("{0:f2}", GetFace(number));
            }
            else if(type == "space")
            {
                Console.WriteLine("{0:f2}", GetSpace(number));
            }
            else if (type == "volume")
            {
                Console.WriteLine("{0:f2}", GetVolume(number));
            }
            else if (type == "area")
            {
                Console.WriteLine("{0:f2}", GetArea(number));
            }
        }

        static double GetFace(double number)
        {
            return Math.Sqrt(2 * number * number);
        }    

        static double GetSpace(double number)
        {
            return Math.Sqrt(3 * number * number);
        }

        static double GetVolume(double number)
        {
            return number * number * number;
        }

        static double GetArea(double number)
        {
            return number * number * 6;
        }
    }
}
