using System;

namespace _06._Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long maxValue = 0;
            long minValue = long.MinValue;

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
            Console.WriteLine(minValue);

            
        }
    }
}
