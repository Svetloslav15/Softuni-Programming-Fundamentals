using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int totalTimes = 0;
            int resultNum = 0;

            for (int index = 0; index < nums.Length; index++)
            {
                int currentNum = nums[index];
                int counter = 0;
                for (int i = index; i < nums.Length; i++)
                {
                    if (nums[i] == currentNum)
                    {
                        counter++;
                        if (counter > totalTimes)
                        {
                            totalTimes = counter;
                            resultNum = currentNum;
                        }
                    }

                }
            }
            Console.WriteLine(resultNum);
            
        }
    }
}
