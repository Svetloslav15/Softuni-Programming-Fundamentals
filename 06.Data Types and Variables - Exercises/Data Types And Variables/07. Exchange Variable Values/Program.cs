using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.Write("a = ");
            Console.WriteLine(first);
            Console.Write("b = ");
            Console.WriteLine(second);

            int x = first;
            first = second;
            second = x;

            Console.WriteLine("After:");
            Console.Write("a = ");
            Console.WriteLine(first);
            Console.Write("b = ");
            Console.WriteLine(second);
        }
    }
}
