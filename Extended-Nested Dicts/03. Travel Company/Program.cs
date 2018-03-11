using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
                
            while (!input.Equals("ready"))
            {
                string[] tokens = input.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string city = tokens[0].Trim();

                if (!dict.ContainsKey(city))
                {
                    dict.Add(city, new Dictionary<string, int>());
                }

                for (int index = 1; index <= tokens.Length - 1; index++)
                {
                    string[] typeAndCapacity = tokens[index].Split('-');
                    string vehicleType = typeAndCapacity[0].Trim();
                    int capacity = int.Parse(typeAndCapacity[1].Trim());

                    if (!dict[city].ContainsKey(vehicleType))
                    {
                        dict[city].Add(vehicleType, new int());
                    }
                    dict[city][vehicleType] = capacity;
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (!input.Equals("travel time!"))
            {
                string[] temp = input.Split();
                string town = temp[0];
                int passengers = int.Parse(temp[1]);

                int sum = CalculatePassengers(dict, town);

                if (sum >= passengers)
                {
                    Console.WriteLine($"{town} -> all {passengers} accommodated");
                }
                else
                {
                    Console.WriteLine($"{town} -> all except {passengers - sum} accommodated");
                }

                input = Console.ReadLine();
            }
        }
        static int CalculatePassengers(Dictionary<string, Dictionary<string, int>> dict, string town)
        {
            int sum = 0;
            foreach (var item in dict.Where(x => x.Key == town))
            {
                sum += item.Value.Values.Sum();
            }
            return sum;
        }
    }
}
