using System;

namespace _01.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

          

            for (int index = 1; index <= numberOfLines; index++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowValue = snowballSnow / snowballTime;
                int value = 1;

                for (int i = 1; i <= snowballQuality; i++)
                {
                    value *= snowValue;
                }

                if (value > max)
                {
                    max = value;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                }

                

                if (index == numberOfLines)
                {
                    Console.WriteLine($"{maxSnow} : {maxTime} = {max} ({maxQuality})");
                }
            }
        }
    }
}
