using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int initialIndex = nums[nums.Count - 1];
            nums.RemoveAt(nums.Count - 1);
            int numberOfSteps = 0;

            List<int> numsCopy = new List<int>();
            SetValuesInCopy(numsCopy, nums);
            int x = 1;
            while (true)
            {
                DecreaseCopy(numsCopy);
                int inputNum = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    for (int index = 0; index <= numsCopy.Count - 1; index++)
                    {
                        if (numsCopy[index] == 0)
                        {
                            if (initialIndex == index)
                            {
                                Console.WriteLine(string.Join(" ", numsCopy));
                                Console.WriteLine(numberOfSteps);
                                return;
                            }
                            else
                            {
                                numsCopy[index] = nums[index];

                            }

                        }

                    }
                    x++;
                }
                else
                {
                    for (int index = 0; index <= numsCopy.Count - 1; index++)
                    {
                        if (numsCopy[index] == 0)
                        {
                            if (inputNum == index)
                            {
                                Console.WriteLine(string.Join(" ", numsCopy));
                                Console.WriteLine(numberOfSteps);
                                return;
                            }
                            else
                            {
                                numsCopy[index] = nums[index];

                            }

                        }

                    }
                }
                numberOfSteps++;
            }
        }

        static void SetValuesInCopy(List<int> numsCopy, List<int> nums)
        {
            for (int index = 0; index <= nums.Count - 1; index++)
            {
                numsCopy.Add(nums[index]);
            }
        }

        static void DecreaseCopy(List<int> numsCopy)
        {
            for (int index = 0; index < numsCopy.Count; index++)
            {
                numsCopy[index]--;
            }
        }
    }
}
