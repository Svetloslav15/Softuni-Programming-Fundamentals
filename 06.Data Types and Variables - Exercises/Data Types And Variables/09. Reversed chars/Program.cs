using System;

namespace _09._Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine($"{(char)c}{(char)b}{(char)a}");
        }
    }
}
