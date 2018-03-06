using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputWords = Console.ReadLine().Split(new char[] {' ', ',', ';', ':', '.', '!', '(', ')',(char)39, (char)34, '\\', '/', '[', ']', (char)32}).ToList();

            List<string> lowerCaseWords = new List<string>();    
            List<string> upperCaseWords = new List<string>();    
            List<string> mixedCaseWords = new List<string>();

            bool haveLowerCase = false;
            bool haveUpperCase = false;

            for (int index = 0; index <= inputWords.Count - 1; index++)
            {
                string currentWord = inputWords[index];

                foreach (var item in currentWord)
                {
                    if (char.IsLower(item))
                    {
                        haveLowerCase = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        haveUpperCase = true;
                    }
                    else 
                    {
                        haveLowerCase = true;
                        haveUpperCase = true;

                    }
                }
                if (haveUpperCase && !haveLowerCase)
                {
                    upperCaseWords.Add(currentWord);
                }
                else if (haveLowerCase && !haveUpperCase)
                {
                    lowerCaseWords.Add(currentWord);
                }
                else if (haveUpperCase && haveLowerCase)
                {
                    mixedCaseWords.Add(currentWord);
                }

                haveLowerCase = false;
                haveUpperCase = false;
            }

            Console.WriteLine("Lower-case: " + String.Join(", ",lowerCaseWords));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + String.Join(", ",upperCaseWords));
        }
    }
}
