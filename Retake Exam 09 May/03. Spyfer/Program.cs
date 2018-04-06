using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int index = 0; index < nums.Count; index++)
            {
                if (index == 0 && nums[index] == nums[index + 1])
                {
                    nums.RemoveAt(index + 1);
                    index = 0;
                }
                else if (index == nums.Count - 1 && nums[nums.Count - 1] == nums[nums.Count - 2])
                {
                    nums.RemoveAt(nums.Count - 2);
                    index = 0;
                }
                else
                {
                    if (index != 0 && index != nums.Count - 1)
                    {
                        int leftNum = nums[index - 1];
                        int num = nums[index];
                        int rightNum = nums[index + 1];

                        int sum = leftNum + rightNum;
                        if (sum == num)
                        {
                            nums.RemoveAt(index - 1);
                            nums.RemoveAt(index);
                            index = 0;
                        }
                    }
                }     
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
