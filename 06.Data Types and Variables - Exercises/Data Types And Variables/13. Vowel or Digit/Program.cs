using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'A' || symbol == 'I' || symbol == 'E' || symbol == 'O' || symbol == 'U' ||
                symbol == 'a' || symbol == 'i' || symbol == 'e' || symbol == 'o' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
