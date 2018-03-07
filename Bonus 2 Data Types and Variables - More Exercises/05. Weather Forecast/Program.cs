using System;

namespace _05._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                sbyte n = sbyte.Parse(input);
                Console.WriteLine("Sunny");
            }
            catch 
            {
                try
                {
                    int n = int.Parse(input);
                    Console.WriteLine("Cloudy");
                }
                catch 
                {
                    try
                    {
                        long n = long.Parse(input);
                        Console.WriteLine("Windy");
                    }
                    catch 
                    {
                        Console.WriteLine("Rainy");
                       
                    }
                    
                }
                
            }
            
        }
    }
}
