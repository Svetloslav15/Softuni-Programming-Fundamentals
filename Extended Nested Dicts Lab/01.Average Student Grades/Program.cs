using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                }
                dict[name].Add(grade);
            }
            foreach (var kvp in dict)
            {
                Console.Write($"{kvp.Key} -> ");
                foreach (var item in kvp.Value)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
