using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            while (number != 0)
            {
                int n = number % 10;
                if (n % 2 == 0)
                {
                    sumEven += n;
                }
                else
                {
                    sumOdd += n;
                }
                number /= 10;
            }
            Console.WriteLine(Sum(sumEven, sumOdd));
        }

        static int Sum(int a, int b)
        {
            int c = a * b;
            return c;
        }
    }
}
