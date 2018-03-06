using System;

namespace _4._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = (double)persons / capacity;

            Console.WriteLine((int)Math.Ceiling((decimal)courses));

            


        }
    }
}
