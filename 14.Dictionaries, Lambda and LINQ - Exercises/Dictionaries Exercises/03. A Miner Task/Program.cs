using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            int counter = 1;
            Dictionary<string, int> minerTask = new Dictionary<string, int>();
            string name = null;
            string resources = null;

            while(resource != "stop")
            {
                if (counter % 2 == 0)
                {
                    if (minerTask.ContainsKey(name))
                    {
                        resources = resource;
                        minerTask[name] += int.Parse(resources);
                    }
                    else
                    {
                        resources = resource;
                        minerTask.Add(name, int.Parse(resources));
                       
                    }
                }
                else 
                {
                    name = resource;
                }


                counter++;
                resource = Console.ReadLine();               
            }

            foreach (var item in minerTask)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
