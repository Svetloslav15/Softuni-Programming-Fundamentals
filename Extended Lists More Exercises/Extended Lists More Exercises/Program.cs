using System;
using System.Linq;

namespace Extended_Lists_More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Distinct().Select(int.Parse).ToArray()));
        }
    }
}
