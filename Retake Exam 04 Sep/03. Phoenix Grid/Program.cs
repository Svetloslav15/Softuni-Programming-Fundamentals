using System;
using System.Text.RegularExpressions;

namespace _03._Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string pattern = @"^([^\s_]{3}\.)+([^\s_]{3})*$";

            while (message != "ReadMe")
            {
                Match match = Regex.Match(message, pattern);

                if (match.Success || message.Length == 3)
                {
                    if (Palindrom(message))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                        
                }
                else
                {
                    Console.WriteLine("NO");
                }
                message = Console.ReadLine();
            }
        }
        static bool Palindrom(string text)
        {
            for (int index = 0; index < text.Length / 2; index++)
            {
                if (text[index] != text[text.Length - 1 - index])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
