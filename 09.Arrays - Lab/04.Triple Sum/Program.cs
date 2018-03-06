using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool have = false;

            for (int first = 0; first < numbers.Length; first++)
            {
                for (int second = first + 1; second < numbers.Length; second++)
                {
                    for (int third = 0; third <= numbers.Length - 1; third++)
                    {
                        if ((second <= numbers.Length - 1) && (numbers[first] + numbers[second] == numbers[third]))
                        {
                            Console.WriteLine($"{numbers[first]} + {numbers[second]} == {numbers[third]}");
                            have = true;
                            break;
                        }
                    }
                }
            }

            if (!have)
            {
                Console.WriteLine("No");
            }
        }
    }
}
