using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> copy = drums.Take(drums.Count).ToList();

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int index = 0; index < drums.Count; index++)
                {
                    drums[index] -= hitPower;                  
                }
                for (int index = 0; index < drums.Count; index++)
                {
                    if (drums[index] <= 0)
                    {
                        int price = copy[index] * 3;
                        if (price > savings)
                        {
                            drums.RemoveAt(index);
                            copy.RemoveAt(index);
                        }
                        else
                        {
                            savings -= price;
                            drums[index] = copy[index];
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",drums));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
