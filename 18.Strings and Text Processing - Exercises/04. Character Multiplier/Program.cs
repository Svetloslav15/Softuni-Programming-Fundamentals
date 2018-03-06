using System;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string firstWord = input[0];
            string secondWord = input[1];

            int minLength = Math.Min(firstWord.Length, secondWord.Length);
            int maxLength = Math.Max(firstWord.Length, secondWord.Length);

            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                char firstChar = firstWord[i];
                char secondChar = secondWord[i];

                sum += firstChar * secondChar;
            }
            
            for (int i = minLength; i < maxLength; i++)
            {
                if (firstWord.Length > secondWord.Length)
                {
                    sum += firstWord[i]; 
                }
                else
                {
                    sum += secondWord[i];
                }
            }
            Console.WriteLine(sum);
   
        }
    }
}
