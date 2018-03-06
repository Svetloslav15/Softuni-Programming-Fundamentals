using System;

namespace _08._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long id = long.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            Console.Write("First name: ");
            Console.WriteLine(firstName);
            Console.Write("Last name: ");
            Console.WriteLine(lastName);
            Console.Write("Age: ");
            Console.WriteLine(age);
            Console.Write("Gender: ");
            Console.WriteLine(gender);
            Console.Write("Personal ID: ");
            Console.WriteLine(id);
            Console.Write("Unique Employee number: ");
            Console.WriteLine(number);

        }
    }
}
