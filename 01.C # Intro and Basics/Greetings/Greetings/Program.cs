using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {id:d8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
