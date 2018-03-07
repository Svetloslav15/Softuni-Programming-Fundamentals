﻿using System;

namespace _03._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                sum += litres;
                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= litres;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
