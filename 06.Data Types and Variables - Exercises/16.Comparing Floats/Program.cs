using System;

namespace _16.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equal = false;
            double substracted = Math.Abs(firstNum - secondNum);

            if (substracted <= eps)
            {
                equal = true;
            }

            Console.WriteLine(equal);


        }
    }
}
