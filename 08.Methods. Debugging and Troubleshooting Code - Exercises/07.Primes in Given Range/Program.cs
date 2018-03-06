using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            List<int> primes = new List<int>();

            for(int num = from; num <= to; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (num < 2)
                {
                    isPrime = false;
                }
                if (isPrime)
                {
                    primes.Add(num);
                }

            }

            Console.WriteLine(String.Join(", ",primes));
        }
    }
}
