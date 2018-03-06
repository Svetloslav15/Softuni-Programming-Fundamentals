using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = first; i >= 1; i--)
            {
                for (int j = 1; j <= second; j++)
                {
                    counter++;
                    sum += (i * j) * 3;
                    if (sum >= stopNumber)
                    {
                        break;
                    }
                }
                if (sum >= stopNumber)
                {
                    break;
                }
            }
            if (sum >= stopNumber)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {stopNumber}");

            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
