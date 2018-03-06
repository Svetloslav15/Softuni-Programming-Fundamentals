using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintLine(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddle(n);
            }
            PrintLine(n);

        }

        static void PrintLine(int n)
        {
            Console.WriteLine(new string('-',2 * n));
        }

        static void PrintMiddle(int n)
        {
            Console.Write('-');
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
