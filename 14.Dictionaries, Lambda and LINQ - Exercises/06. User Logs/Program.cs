using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._User_Logs
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, int>> dict = new SortedDictionary<string, Dictionary<string, int>>();

            while(input != "end")
            {
                string[] tokens = input.Split(' ');
                string[] ips = tokens[0].Split('=');
                string[] us = tokens[2].Split('=');
                string[] mes = tokens[1].Split('=');
                
                string ipAddress = ips[1];
                string message = mes[1];
                string username = us[1];

                if (!dict.ContainsKey(username))
                {
                    dict.Add(username, new Dictionary<string, int>());
                    if (!dict[username].ContainsKey(ipAddress))
                    {
                        dict[username].Add(ipAddress, 1);
                    }
                    else
                    {
                        dict[username][ipAddress]++;
                    }
                }
                else
                {
                    if (!dict[username].ContainsKey(ipAddress))
                    {
                        dict[username].Add(ipAddress, 1);
                    }
                    else
                    {
                        dict[username][ipAddress]++;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var vkp in kvp.Value)
                {
                    if (vkp.Key != kvp.Value.Keys.Last())
                    {
                        Console.Write($"{vkp.Key} => {vkp.Value}, ");
                    }
                    else
                    {
                        Console.Write($"{vkp.Key} => {vkp.Value}. ");

                    }
                }
                Console.WriteLine();
            }
        }        
    }
}
