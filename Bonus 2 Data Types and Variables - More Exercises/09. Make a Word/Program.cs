using System;

namespace _09._Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string word = null;

            for (int i = 0; i < num; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word += symbol;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
