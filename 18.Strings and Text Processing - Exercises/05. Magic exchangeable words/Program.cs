using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                .ReadLine()
                .Split(' ');
                
            string firstWord = input[0];
            string secondWord = input[1];
            firstWord = new string(firstWord.Distinct().ToArray());
            secondWord = new string(secondWord.Distinct().ToArray());
            if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
