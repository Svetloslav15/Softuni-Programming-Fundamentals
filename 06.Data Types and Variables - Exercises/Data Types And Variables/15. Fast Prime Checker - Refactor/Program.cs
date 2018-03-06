using System;

namespace _15._Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (i >= 2)
                Console.WriteLine($"{i} -> {isPrime}");
            }

        }
    }
}
