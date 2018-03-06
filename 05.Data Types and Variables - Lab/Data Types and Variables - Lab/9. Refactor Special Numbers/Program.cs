using System;

namespace _9._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int x = 0;
            bool isDivided = false;
            for (int i = 1; i <= number; i++)
            {
                x = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isDivided = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{x} -> {isDivided}");
                sum = 0;
                i = x;
            }

        }
    }
}
