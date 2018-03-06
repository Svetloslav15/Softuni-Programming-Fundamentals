using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(number);
            int trailingZeros = CalculateTrailingZeros(factorial);
            Console.WriteLine(trailingZeros);
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int CalculateTrailingZeros(BigInteger factorial)
        {
            int counter = 0;
            while(factorial != 0)
            {
                if (factorial % 10 == 0)
                {
                    counter++;
                }
                else 
                {
                    break;
                }
                factorial /= 10;
            }
            return counter;
        }
    }
}
