using System;

namespace _02._Circle_Area_Precision_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double s = r * Math.PI * r;
            Console.WriteLine(Math.Round(s, 12));
        }
    }
}
