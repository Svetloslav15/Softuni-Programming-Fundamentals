using System;

namespace _01._X
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number / 2; i++)
            {
                Console.WriteLine("{1}x{0}x", new string(' ',(number - 2 - 2 * i)),new string(' ',i));
            }

            Console.WriteLine("{0}x",
                new string(' ',number / 2));

            for (int i = number / 2, c = 0; i > 0; i--,c++)
            {
                Console.WriteLine("{0}x{1}x",
                    new string(' ',i - 1),
                    new string(' ',2 * c + 1));
            }
        }
    }
}
