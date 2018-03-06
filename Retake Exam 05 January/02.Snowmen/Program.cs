using System;
using System.Collections.Generic;
using System.Linq;

class Snowmen
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        while (nums.Length > 1)
        {
            List<int> losers = new List<int>();

            for (int index = 0; index <= nums.Length - 1; index++)
            {
                int attacker = index;
                int target = nums[index] % nums.Length;
              
                int diff = Math.Abs(attacker - target);

                if (nums.Length - losers.Count == 1)
                {
                    break;
                }
                if (losers.Contains(attacker))
                {
                    continue;
                }

                if (attacker == target)
                {
                    Console.WriteLine($"{attacker} performed harakiri");
                    losers.Add(attacker);
                    nums[attacker] = -1;
                }
                else if (diff % 2 == 0)
                {
                    Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    losers.Add(target);
                    nums[target] = -1;
                }
                else
                {
                    Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    losers.Add(attacker);
                    nums[attacker] = -1;
                }

                losers = losers.Distinct().ToList();
            }
            nums = nums.Where(x => x != -1).ToArray();
        }
    }
}