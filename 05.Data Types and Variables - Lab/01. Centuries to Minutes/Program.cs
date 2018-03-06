using System;

namespace _01._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centeries = byte.Parse(Console.ReadLine());
            int years = centeries * 100;
            int days = (int)(years * 365.2422m);
            decimal hours = days * 24;
            decimal minutes = hours * 60;

            Console.WriteLine($"{centeries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
