using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            int sum = 0;
            int count = 0;

            for (int index = 0; index <= input.Count - 1; index++)
            {
                for (int i = 0; i < input[index].Length; i++)
                {
                    sum += input[index][i];
                    count++;
                }
            }

            int average = sum / count;
            string symbol = Convert.ToChar(average).ToString().ToUpper();

            Console.WriteLine(string.Join($"{symbol}", input));
        }
    }
}
