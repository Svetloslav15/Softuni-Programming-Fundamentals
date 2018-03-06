using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(c => int.Parse(c))
                .ToList();

            string[] operations = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while(operations[0] != "Even" && operations[0] != "Odd")
            {
                if (operations[0] == "Delete")
                {
                    int num = Convert.ToInt32(operations[1]);
                    nums.RemoveAll(n => n == num);
                }
                else if (operations[0] == "Insert")
                {
                    int element = Convert.ToInt32(operations[1]);
                    int index = Convert.ToInt32(operations[2]);
                    nums.Insert(index, element);
                }
                operations = Console.ReadLine()
                .Split(' ')
                .ToArray();
            }

           if (operations[0] == "Odd")
           {
                foreach (var item in nums)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write(item + " ");
                    }
                }
           }
           else
            {
                foreach (var item in nums)
                {
                    if (item % 2 == 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
