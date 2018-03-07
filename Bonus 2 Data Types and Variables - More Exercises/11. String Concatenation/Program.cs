using System;

namespace _11._String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            string output = null;

            for (int i = 1; i <= counter; i++)
            {
                string input = Console.ReadLine();
                if (type == "even")
                {
                    if (i % 2 == 0)
                    {
                        output += input + symbol;
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        output += input + symbol;
                    }
                }
            }
            for (int i = 0; i < output.Length - 1; i++)
            {
                Console.Write(output[i]);
            }
        }
    }
}
