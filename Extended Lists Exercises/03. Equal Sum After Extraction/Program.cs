using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int index = 0; index < firstList.Count; index++)
            {
                int number = firstList[index];
                if (secondList.Contains(number))
                {
                    
                    secondList.Remove(number);
                }
            }

            int firstSum = firstList.Sum();
            int secondSum = secondList.Sum();

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstSum - secondSum)}");
            }

        }
    }
}
