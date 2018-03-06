using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTop(n);
            PrintBottom(n);
        }

        static void PrintTop(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintBottom(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
