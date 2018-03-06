using System;

namespace _07._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberPow(number, pow));
        }

        static double NumberPow(double number, int pow)
        {
            double powedNum = 1;
            for (int i = 1; i <= pow; i++)
            {
                powedNum *= number;
            }

            return powedNum;
        }
    }
}
