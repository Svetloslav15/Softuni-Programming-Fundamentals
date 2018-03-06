using System;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var letter in input)
            {
                string result = string.Format("\\u{0:x4}", (int)letter);
                Console.Write(result);
            }
        }
    }
}
