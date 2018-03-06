using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numsAasText = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();

            foreach (var num in numsAasText)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            foreach (var num in dict.Keys)
            {
                Console.WriteLine($"{num} -> {dict[num]}");
            }
            
        }
    }
}
