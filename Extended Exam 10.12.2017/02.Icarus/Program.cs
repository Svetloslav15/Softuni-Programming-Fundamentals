using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> plane = Console.ReadLine().Split().Select(int.Parse).ToList();
            int icarusStart = int.Parse(Console.ReadLine());
            int damage = 1;

            string command = Console.ReadLine();

            while (command != "Supernova")
            {
                string[] tokens = command.Split();
                string side = tokens[0];
                int steps = int.Parse(tokens[1]);

                if (side == "right")
                {
                    for (int step = 1; step <= steps; step++)
                    {
                        if (icarusStart >= plane.Count - 1)
                        {
                            icarusStart = -1;
                            damage++;
                        }
                        icarusStart++;
                        plane[icarusStart] -= damage; ;
                    }
                }
                else if (side == "left")
                {
                    for (int step = 1; step <= steps; step++)
                    {
                        if (icarusStart <= 0)
                        {
                            icarusStart = plane.Count;
                            damage++;
                        }
                        icarusStart--;
                        plane[icarusStart] -= damage;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
