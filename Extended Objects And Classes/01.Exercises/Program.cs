using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Exercise> exercises = new List<Exercise>();

            while (input != "go go go")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = tokens[0];
                string courseName = tokens[1];
                string judgeContestLink = tokens[2];
                List<string> problems = tokens[3].Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
                Exercise exercise = new Exercise();
                exercise.Topic = topic;
                exercise.CourseName = courseName;
                exercise.JudgeContestLink = judgeContestLink;
                exercise.Problems = problems;
                exercises.Add(exercise);

                input = Console.ReadLine();
            }

            foreach (var exer in exercises)
            {
                Console.WriteLine($"Exercises: {exer.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exer.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exer.JudgeContestLink}");
                int counter = 1;
                foreach (var item in exer.Problems)
                {
                    Console.WriteLine($"{counter++}. {item}");
                }
            }
        }
    }

    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }
}
