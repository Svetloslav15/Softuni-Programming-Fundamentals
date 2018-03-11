using System;
using System.Collections.Generic;

namespace _03.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> people = new List<string>();

            for (int i = 1; i <= number; i++)
            {
                string name = Console.ReadLine();
                if (!people.Contains(name))
                {
                    people.Add(name);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
