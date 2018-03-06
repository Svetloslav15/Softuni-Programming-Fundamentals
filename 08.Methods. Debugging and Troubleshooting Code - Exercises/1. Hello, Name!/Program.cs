using System;

namespace _1._Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }
        static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
