using System;
using System.Numerics;

namespace _10._Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            decimal days = Math.Floor(years * 365.242m);
            int hours = (int)days * 24;            
            long minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;           
            ulong miliseconds = seconds * 1000;           
            BigInteger microseconds = miliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
