using System;

namespace _07._Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            decimal id = GetId(n, type);
            decimal years = Math.Ceiling(Math.Abs((decimal)id) / 127);
            if (years != 1)
            {
                Console.WriteLine($"Prisoner with id {id} is sentenced to {years} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {id} is sentenced to {years} year");
            }
        }

        static long GetId(int n, string type)
        { 
            long maxValue = 0;
            long minValue = long.MinValue;
            long currentNum = 0;

            if (type == "int")
            {
                maxValue = int.MaxValue;

            }
            else if (type == "long")
            {
                maxValue = long.MaxValue;

            }
            else if (type == "sbyte")
            {
                maxValue = sbyte.MaxValue;

            }

            for (int i = 1; i <= n; i++)
            {
                long number = long.Parse(Console.ReadLine());

                if (number <= maxValue && number > minValue)
                {
                    minValue = number;
                }
            }
            return minValue;
        }
    }
}
                    
                


    