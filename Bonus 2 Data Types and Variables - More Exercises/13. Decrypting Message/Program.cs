using System;

namespace _13._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = null;

            for (int i = 1; i <= n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                message += (char)(symbol + key);
            }
            Console.WriteLine(message);
        }
    }
}
