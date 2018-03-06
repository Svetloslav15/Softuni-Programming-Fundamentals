using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char notUsed = char.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    for (int k = first; k <= second; k++)
                    {
                        if (i != notUsed && j != notUsed && k != notUsed)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        }

                    }
                }
            }

        }
    }
}
