using System;

namespace _12._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeyCapacity = 0.0;
            string biggestModel = null;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolume = Math.PI * radius * radius * height;

                if (currentVolume > biggestKeyCapacity)
                {
                    biggestModel = model;
                    biggestKeyCapacity = currentVolume;
                }

            }

            Console.WriteLine(biggestModel);

            
        }
    }
}
