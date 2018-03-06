using System;

namespace _6._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int i1 = 0; i1 < number; i1++)
                {
                    for (int i2 = 0; i2 < number; i2++)
                    {
                        char symbol = (char)('a' + i);
                        char symbol1 = (char)('a' + i1);
                        char symbol2 = (char)('a' + i2);
                        Console.WriteLine($"{symbol}{symbol1}{symbol2}");
                    }
                }
            }
            
                    
            
        }
    }
}
