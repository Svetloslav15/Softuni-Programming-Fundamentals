using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            string command = Console.ReadLine();
            while(command != "print")
            {
                string[] argument = command.Split(' ').ToArray();
                
                if (argument[0] == "add")
                {
                    int index = int.Parse(argument[1]);
                    int element = int.Parse(argument[2]);

                    nums.Insert(index, element);
                }

                else if (argument[0] == "addMany")
                {
                    int index = int.Parse(argument[1]);
                    List<int> elements = new List<int>();
                    for (int i = 2; i < argument.Length; i++)
                    {
                        elements.Add(int.Parse(argument[i]));
                    }
                    nums.InsertRange(index, elements);
                }
                else if (argument[0] == "contains")
                {
                    Console.WriteLine(nums.IndexOf(int.Parse(argument[1])));
                }
                else if (argument[0] == "remove")
                {
                    int index = int.Parse(argument[1]);
                    nums.RemoveAt(index);
                }
                else if (argument[0] == "shift")
                {
                    int rotations = int.Parse(argument[1]);
                    for (int i = 1; i <= rotations; i++)
                    {
                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }
                    
                }
                else if (argument[0] == "sumPairs")
                {
                    for (int i = 0; i < nums.Count - 1; i++)
                    {
                        nums[i] += nums[i + 1];
                        nums.RemoveAt(i + 1);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine('[' + string.Join(", ",nums) + ']');
        }
    }
}
