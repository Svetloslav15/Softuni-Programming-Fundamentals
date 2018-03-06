using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(String.Join("", secondArray));
                Console.WriteLine(String.Join("", firstArray));
                return;
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine(String.Join("", firstArray));
                Console.WriteLine(String.Join("", secondArray));
                return;
            }

            else
            {
                for (int index = 0; index < firstArray.Length; index++)
                {
                    if (firstArray[index] != secondArray[index])
                    {
                        if (secondArray[index] > firstArray[index])
                        {
                            Console.WriteLine(String.Join("", firstArray));
                            Console.WriteLine(String.Join("", secondArray));
                            return;
                        }
                        else
                        {
                            Console.WriteLine(String.Join("", secondArray));
                            Console.WriteLine(String.Join("", firstArray));
                            return;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join("", secondArray));
            Console.WriteLine(String.Join("", firstArray));
        }
    }
}
