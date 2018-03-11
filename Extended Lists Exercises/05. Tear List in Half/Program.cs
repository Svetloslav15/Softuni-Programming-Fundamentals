using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split()
                .ToList();

            List<string> bottom = new List<string>();
            List<string> upper = new List<string>();
            for (int index = 0; index < inputList.Count / 2; index++)
            {
                bottom.Add(inputList[index]);
            }
            for (int index = inputList.Count / 2; index <= inputList.Count - 1; index++)
            {
                upper.Add(inputList[index]);
            }

            List<string> final = new List<string>();

            for (int index = 0; index <= upper.Count - 1; index++)
            {
                final.Add(NumFir(upper[index]));
                final.Add(bottom[index]);
                final.Add(NumSec(upper[index]));
            }

            Console.WriteLine(string.Join(" ", final));
        }

        static string NumFir(string number)
        {
            char num = number[0];
            return num.ToString();
        }

        static string NumSec(string number)
        {
            char num = number[1];
            return num.ToString();
        }
    }
}
