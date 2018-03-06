using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <= ",nums));

           
        }
    }
}
