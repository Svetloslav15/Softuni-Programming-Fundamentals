using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var sortedNums = input.OrderByDescending(x => x);
            
            Console.WriteLine(string.Join(" ",sortedNums.Take(3)));
        }
    }
}
