using System;

namespace _03._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            int minutesAfter = (minutes + 30);

            Console.WriteLine($"{(minutesAfter / 60 + hours) % 24}:{minutesAfter % 60:D2}");
            
        }
    }
}
