using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            int last = 0;
            int counter = 0;
            while (input != "stop")
            {
                counter++;
                if (numbers.Count == 0 && counter != 1)
                {
                     Console.WriteLine($"nobody left to shoot! last one was {last}");
                     return;
                }
                try
                {
                    int number = int.Parse(input);
                    numbers.Insert(0, number);
                }
                catch 
                {
                    double average = numbers.Average();
                    for (int index = 0; index <= numbers.Count - 1; index++)
                    {
                        if (numbers[index] <= average)
                        {
                            last = numbers[index];
                            Console.WriteLine($"shot {numbers[index]}");
                            numbers.RemoveAt(index);
                            break;
                        }
                    }
                    for (int index = 0; index <= numbers.Count - 1; index++)
                    {
                        numbers[index]--;
                    }
                }

                input = Console.ReadLine();
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine($"you shot them all. last one was {last}");
            }
            else
            {
                Console.WriteLine($"survivors: {string.Join(" ", numbers)}");
            }
        }
    }
}
