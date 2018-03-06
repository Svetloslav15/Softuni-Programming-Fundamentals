using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine().ToLower();
            string[] input = arr
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', (char)34, (char)39, '\\', '/', '!', '?',' ' },StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> result = input.Where(x => x.Length < 5).OrderBy(x => x).ToList();
            
            Console.WriteLine(string.Join(", ",result.Distinct()));
        }
    }
}
