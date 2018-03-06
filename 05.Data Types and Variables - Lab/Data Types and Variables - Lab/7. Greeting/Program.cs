using System;

namespace _7._Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}
