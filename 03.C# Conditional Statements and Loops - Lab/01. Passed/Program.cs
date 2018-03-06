using System;

namespace _01._Passed
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
        }
    }
}
