using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ulong fib = FibonacciN(n);

            Console.WriteLine(fib);
        }

        static ulong FibonacciN(int n)
        {
            ulong f0 = 1;
            ulong f1 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                ulong fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }

            return f1;

        }
    }
}

