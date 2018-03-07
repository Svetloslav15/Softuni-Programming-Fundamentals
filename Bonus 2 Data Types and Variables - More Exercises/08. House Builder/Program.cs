using System;
using System.Numerics;

namespace _08._House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int sbytePrice = 0;
            int intPrice = 0;

            if (firstNum > 127)
            {
                sbytePrice = secondNum;
                intPrice = firstNum;

            }
            else
            {
                sbytePrice = firstNum;
                intPrice = secondNum;
            }

            BigInteger totalPrice = 10 * (BigInteger)intPrice + 4 * sbytePrice;
            
            Console.WriteLine(totalPrice);
        }
    }
}
