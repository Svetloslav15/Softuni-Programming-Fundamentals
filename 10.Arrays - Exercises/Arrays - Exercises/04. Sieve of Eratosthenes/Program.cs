using System;
using System.Collections.Generic;

namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool[] primes = new bool[number + 1];

            for (int i = 0; i <= primes.Length - 1; i++)
            {
                primes[i] = true;
               
            }

            primes[0] = false;
            primes[1] = false;

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    for (int j = 2; j * i <= primes.Length - 1; j++)
                    {
                        primes[j * i] = false;
                    }
                }
            }
            
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
