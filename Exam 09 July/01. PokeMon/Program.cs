using System;

namespace _01._PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            decimal copyN = n;
            long count = 0;

            while (n >= m)
            {
                n -= m;
                decimal percentage = 0.5m * copyN;
                if (percentage == n && y != 0)
                {
                    n /= y;
                }
                count++;
            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
