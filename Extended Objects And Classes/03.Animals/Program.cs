using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Snake> snakes = new List<Snake>();

            string command = Console.ReadLine();
            while (command != "I'm your Huckleberry")
            {
                string[] tokens = command.Split();
                string type = tokens[0];

                if (type == "Dog")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int numOFLegs = int.Parse(tokens[3]);
                    Dog dog = new Dog(name, age, numOFLegs);
                    dogs.Add(dog);
                }
                else if (type == "Cat")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int iq = int.Parse(tokens[3]);
                    Cat cat = new Cat(name, age, iq);
                    cats.Add(cat);
                }
                else if (type == "Snake")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int crueltyCoefficient = int.Parse(tokens[3]);
                    Snake snake = new Snake(name, age, crueltyCoefficient);
                    snakes.Add(snake);
                }
                else
                {
                    if (cats.Any(x => x.Name == tokens[1]))
                    {
                        Cat.ProduceSound();
                    }
                    else if (dogs.Any(x => x.Name == tokens[1]))
                    {
                        Dog.ProduceSound();
                    }
                    else
                    {
                        Snake.ProduceSound();
                    }
                    
                }
                command = Console.ReadLine();
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IQ}");
            }
            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public Dog(string name, int age, int legs)
        {
            Name = name;
            Age = age;
            NumberOfLegs = legs;
        }
        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IQ { get; set; }
        public Cat(string name, int age, int iq)
        {
            Name = name;
            Age = age;
            IQ = iq;
        }
        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }
        public Snake(string name, int age, int crueltyCoefficient)
        {
            Name = name;
            Age = age;
            CrueltyCoefficient = crueltyCoefficient;
        }
        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

}
