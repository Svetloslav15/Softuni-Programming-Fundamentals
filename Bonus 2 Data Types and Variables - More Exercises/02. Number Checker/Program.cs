using System;

namespace _02._Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long n = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch 
            {
                Console.WriteLine("floating-point");
                
            }
                    
        }
    }
}
