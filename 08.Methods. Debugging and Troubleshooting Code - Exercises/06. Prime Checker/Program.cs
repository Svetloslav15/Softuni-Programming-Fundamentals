using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            bool isPrime = true;
            if (number > 1)
            {
                for (long i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (number < 2)
            {
                isPrime = false;
            }

            return isPrime;
           
        }
    }
}
