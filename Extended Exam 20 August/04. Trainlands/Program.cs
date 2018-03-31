using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<Wagon>> trains = new Dictionary<string, List<Wagon>>();

            while (input != "It's Training Men!")
            {
                string[] tokens = input.Split(new[] { " -> ", " : ", " = " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 3)
                {
                    string trainName = tokens[0];
                    string wagonName = tokens[1];
                    int wagonPower = int.Parse(tokens[2]);

                    if (trains.Keys.Contains(trainName))
                    {
                        Wagon wagon = new Wagon(wagonName, wagonPower);

                        trains[trainName].Add(wagon);
                    }
                    else
                    {
                        Wagon wagon = new Wagon(wagonName, wagonPower);
                        trains.Add(trainName, new List<Wagon>());
                        trains[trainName].Add(wagon);
                    }
                }
                if (tokens.Length == 2)
                {
                    if (input.Contains("->"))
                    {
                        string trainName = tokens[0];
                        string otherTrainName = tokens[1];

                        if (!trains.Keys.Contains(trainName))
                        {
                            trains.Add(trainName, new List<Wagon>());
                        }

                        var wagons = trains[otherTrainName];
                        trains[trainName].AddRange(wagons);
                        int count = trains[otherTrainName].Count;
                        trains[otherTrainName].RemoveRange(0, count);
                    }
                    else if (input.Contains("="))
                    {
                        string trainName = tokens[0];
                        string otherTrainName = tokens[1];

                        if (!trains.Keys.Contains(trainName))
                        {
                            trains.Add(trainName, new List<Wagon>());
                        }

                        int count = trains[trainName].Count;
                        trains[trainName].RemoveRange(0, count);
                        var wagons = trains[otherTrainName];
                        trains[trainName].AddRange(wagons);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var train in trains.OrderByDescending(y => y.Value.Sum(x => x.Power)).ThenBy(x => x.Value.Count))
            {
                if (train.Value.Count != 0)
                {
                    Console.WriteLine($"Train: {train.Key}");
                    foreach (var wagon in train.Value.OrderByDescending(x => x.Power))
                    {
                        Console.WriteLine($"###{wagon.Name} - {wagon.Power}");
                    }
                }
            }

        }
    }


    class Wagon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Wagon(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }

}