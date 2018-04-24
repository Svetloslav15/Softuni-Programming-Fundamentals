using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(' ');
                if (tokens[0] == "exchange")
                {
                    int index = int.Parse(tokens[1]);
                    ExchangeList(nums, index);
                }
                else if (tokens[0] == "max")
                {
                    string type = tokens[1];
                    MaxIndex(nums, type);
                }
                else if (tokens[0] == "min")
                {
                    string type = tokens[1];
                    MinIndex(nums, type);
                }
                else if (tokens[0] == "first")
                {
                    int count = int.Parse(tokens[1]);
                    string type = tokens[2];
                    FirstEl(nums, count, type);
                }
                else if (tokens[0] == "last")
                {
                    int count = int.Parse(tokens[1]);
                    string type = tokens[2];
                    LastEl(nums, count, type);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        static void LastEl(List<int> nums, int count, string type)
        {
            if (count > nums.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (type == "even")
            {
                List<int> evens = nums.Where(x => x % 2 == 0).ToList();
                if (count > evens.Count)
                {
                    Console.WriteLine("[" + string.Join(", ", evens) + "]");
                }
                else
                {
                    evens = evens.Skip(evens.Count - count).Take(count).ToList();
                    Console.WriteLine("[" + string.Join(", ", evens) + "]");
                }
            }
            else if (type == "odd")
            {
                List<int> odds = nums.Where(x => x % 2 != 0).ToList();
                if (count > odds.Count)
                {
                    Console.WriteLine("[" + string.Join(", ", odds) + "]");
                }
                else
                {
                    odds = odds.Skip(odds.Count - count).Take(count).ToList();
                    Console.WriteLine("[" + string.Join(", ", odds) + "]");
                }
            }
        }

        static void FirstEl(List<int> nums, int count, string type)
        {
            if (count > nums.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (type == "even")
            {
                List<int> evens = nums.Where(x => x % 2 == 0).ToList();
                if (count > evens.Count)
                {
                    Console.WriteLine("[" + string.Join(", ",evens) + "]");
                }
                else
                {
                    evens = evens.Take(count).ToList();
                    Console.WriteLine("[" + string.Join(", ", evens) + "]");
                }
            }
            else if (type == "odd")
            {
                List<int> odds = nums.Where(x => x % 2 != 0).ToList();
                if (count > odds.Count)
                {
                    Console.WriteLine("[" + string.Join(", ", odds) + "]");
                }
                else
                {
                    odds = odds.Take(count).ToList();
                    Console.WriteLine("[" + string.Join(", ", odds) + "]");
                }
            }
        }

        static void MinIndex(List<int> nums, string type)
        {
            List<int> temp = new List<int>();

            if (type == "odd")
            {
                temp = nums.Where(x => x % 2 != 0).ToList();
            }
            else if (type == "even")
            {
                temp = nums.Where(x => x % 2 == 0).ToList();
            }
            if (temp.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int minEl = temp.Min();
                Console.WriteLine(nums.LastIndexOf(minEl));
            }
        }

        static void MaxIndex(List<int> nums, string type)
        {
            List<int> filtered = new List<int>();
            if (type == "odd")
            {
                filtered = nums.Where(x => x % 2 != 0).ToList();
            }
            else if (type == "even")
            {
                filtered = nums.Where(x => x % 2 == 0).ToList();
            }
            if (filtered.Count != 0)
            {
                int maxN = filtered.Max();
                Console.WriteLine(nums.LastIndexOf(maxN));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void ExchangeList(List<int> nums, int index)
        {
            if (index < 0 || index > nums.Count - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            for (int currentIndex = nums.Count - 1; currentIndex > index; currentIndex--)
            {
                int num = nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);
                nums.Insert(0, num);
            }
        }
    }
}
