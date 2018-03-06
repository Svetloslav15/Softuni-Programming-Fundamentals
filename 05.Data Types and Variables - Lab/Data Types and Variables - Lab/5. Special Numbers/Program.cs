using System;

namespace _5._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            bool isDivided = false;

            for (int i = 1; i <= number; i++)
            {
                int x = i;
                int sum = 0;
                while(x != 0)
                {
                    sum += x % 10;
                    x /= 10;
                }
                
                if (sum == 5 || sum  == 7 || sum == 11)
                {
                    isDivided = true;
                }
                else
                {
                    isDivided = false;
                }
                
                Console.WriteLine($"{i} -> {isDivided}");
            }
        }
    }
}
