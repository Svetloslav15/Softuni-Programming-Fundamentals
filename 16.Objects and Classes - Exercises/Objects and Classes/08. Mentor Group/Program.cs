using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08._Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (firstInput != "end of dates")
            {
                string[] tokens = firstInput.Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
                string currentName = tokens[0];
                List<DateTime> currentDates = tokens.Skip(1).Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();

                if (students.Any(x => x.Name == currentName))
                {
                    Student studentE = students.Where(x => x.Name == currentName).First();
                    studentE.Dates.AddRange(currentDates);                    
                }
                else
                {
                    Student studentE = new Student(currentName, new List<string>(), currentDates);
                    students.Add(studentE);
                }
               
                firstInput = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "end of comments")
            {
                string[] secondTokens = secondInput.Split('-');
                string studentName = secondTokens[0];
                string comment = secondTokens[1];

                if (students.Any(x => x.Name == studentName))
                {
                    Student student = students.Where(x => x.Name == studentName).First();
                    student.Comments.Add(comment);
                }
                secondInput = Console.ReadLine();
            }

            foreach (Student student in students.OrderBy(X => X.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");

                foreach (var stud in student.Comments)
                {
                    Console.WriteLine($"- {stud}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var stud in student.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {stud.ToString("dd/MM/yyyy")}", stud);
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }

        public Student(string name, List<string> comments, List<DateTime> dates)
        {
            Name = name;
            Comments = comments;
            Dates = dates;
        }
    }
}



