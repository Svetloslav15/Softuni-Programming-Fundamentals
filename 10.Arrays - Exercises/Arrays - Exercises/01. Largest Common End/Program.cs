using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int length = Math.Min(firstArray.Length, secondArray.Length);
            int count = 0;
            bool have = false;

            for (int i = 0; i <= length - 1; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    have = true;
                    count++;
                }
            }
            if (!have)
            {
                for (int i = length - 1; i >= 0; i--)
                {
                    if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                    {
                        count++;
                    }
                }

            }

            Console.WriteLine(count);

        }
    }
}
