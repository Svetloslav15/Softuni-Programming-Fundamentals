using System;
using System.Linq;
using System.Collections.Generic;

namespace _11.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                .Split('|')
                .ToList();
            nums.Reverse();

            List<string> result = new List<string>();

            foreach (var num in nums)
            {
                List<string> last = num.Split(' ').ToList();

                foreach (var item in last)
                {
                    if (item != "")
                    {
                        result.Add(item);
                    }                    
                }

            }

            Console.WriteLine(String.Join(" ",result));
        }
    }
}
