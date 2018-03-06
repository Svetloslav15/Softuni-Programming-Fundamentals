using System;

namespace _05._Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool endsInY = word.EndsWith("y");
            bool endsInLLL = word.EndsWith("o") ||
                word.EndsWith("ch") ||
                word.EndsWith("s") ||
                word.EndsWith("sh") ||
                word.EndsWith("x") ||
                word.EndsWith("z");

            if (endsInY)
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (endsInLLL)
            {
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
