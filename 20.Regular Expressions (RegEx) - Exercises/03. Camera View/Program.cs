using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int numsToSkip = nums[0];
            int numsToTake = nums[1];
            string input = Console.ReadLine();

            string pattern = @"\|<(.*?)(?=\||$)";

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> result = new List<string>();
            foreach (Match word in matches)
            {
                char[] something = word.Groups[1].ToString().Skip(numsToSkip).Take(numsToTake).ToArray();
                string s = string.Concat(something);
                result.Add(s);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
