﻿using System;

namespace _02._Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            float grade = float.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
