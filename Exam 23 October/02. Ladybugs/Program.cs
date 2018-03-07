using System;
using System.Linq;

namespace _02._Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fileSize = int.Parse(Console.ReadLine());

            int[] field = new int[fileSize];

            long[] indexesWithLadyBugs = Console.ReadLine().Split().Select(long.Parse).ToArray();
            for (int i = 0; i < indexesWithLadyBugs.Length; i++)
            {
                if (indexesWithLadyBugs[i] >= 0 && indexesWithLadyBugs[i] <= field.Length - 1)
                {
                    field[indexesWithLadyBugs[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                long ladyBugIndex = long.Parse(tokens[0]);
                string position = tokens[1];
                long stepsToFly = long.Parse(tokens[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (position == "right")
                {
                    if (field[ladyBugIndex] == 1)
                    {
                        if (stepsToFly >= 0)
                        {
                            GoRight(ladyBugIndex, stepsToFly, field.Length, field);
                        }
                        else
                        {
                            GoLeft(ladyBugIndex, stepsToFly, field.Length, field);
                        }
                    }
                }
                else if (position == "left")
                {
                    if (field[ladyBugIndex] == 1)
                    {
                        if (stepsToFly < 0)
                        {
                            GoRight(ladyBugIndex, stepsToFly, field.Length, field);
                        }
                        else
                        {
                            GoLeft(ladyBugIndex, stepsToFly, field.Length, field);
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        static void GoRight(long ladyBugIndex, long stepsToFly, long fieldLength, int[] field)
        {
            stepsToFly = Math.Abs(stepsToFly);
            field[ladyBugIndex] = 0;
            while (true)
            {
                if (ladyBugIndex + stepsToFly >= field.Length)
                {
                    break;
                }
                if (field[ladyBugIndex + stepsToFly] == 0)
                {
                    field[ladyBugIndex + stepsToFly] = 1;
                    break;
                }
                else
                {
                    ladyBugIndex += stepsToFly;
                }
            }
        }

        static void GoLeft(long ladyBugIndex, long stepsToFly, long fieldLength, int[] field)
        {
            stepsToFly = Math.Abs(stepsToFly);
            field[ladyBugIndex] = 0;
            while (true)
            {
                if (ladyBugIndex - stepsToFly < 0)
                {
                    break;
                }
                if (field[ladyBugIndex - stepsToFly] == 0)
                {
                    field[ladyBugIndex - stepsToFly] = 1;
                    break;
                }
                else
                {
                    ladyBugIndex -= stepsToFly;
                }
            }
        }
    }
}
