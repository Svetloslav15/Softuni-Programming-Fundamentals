using System;

namespace _01._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            int count = 0;
            int indexx = -1;

            while (true)
            {
                int index = input.IndexOf(pattern, indexx + 1);

                if (count == -1)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
