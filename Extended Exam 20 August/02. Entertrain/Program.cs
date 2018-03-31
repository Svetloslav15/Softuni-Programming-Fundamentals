using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locomotivesPower = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            List<int> train = new List<int>();

            while (input != "All ofboard!")
            {
                int wagon = int.Parse(input);
                train.Add(wagon);
                int sum = train.Sum();

                if (sum > locomotivesPower)
                {
                    int average = sum / train.Count;
                    int closest = train.OrderBy(x => Math.Abs(x - average)).First();

                    train.Remove(closest);
                }

                input = Console.ReadLine();
            }

            train.Insert(0, locomotivesPower);
            train.Reverse();


            Console.WriteLine(string.Join(" ", train));
        }
    }
}
