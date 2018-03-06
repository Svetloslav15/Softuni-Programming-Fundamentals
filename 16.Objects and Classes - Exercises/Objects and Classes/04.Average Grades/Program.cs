using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int countStudents = 1; countStudents <= numberOfStudents; countStudents++)
            {
                string[] studentsInfo = Console.ReadLine().Split(' ');

                Student student = new Student();
                student.Name = studentsInfo[0];
                student.Grades = studentsInfo.Skip(1).Select(x => double.Parse(x)).ToList();
                students.Add(student);
            }

            foreach (var kvp in students.OrderBy(x => x.Name).ThenByDescending(x => x.Average).ToList())
            {
                if (kvp.Average >= 5.00)
                {
                    Console.WriteLine($"{kvp.Name} -> {kvp.Average:F2}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average => Grades.Average();


    }
}
