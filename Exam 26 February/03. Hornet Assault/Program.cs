using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehavies = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int index = 0; index <= beehavies.Count - 1; index++)
            {
                long hornetsPower = hornets.Sum();
                if (beehavies[index] >= hornetsPower)
                {
                    if (hornets.Count == 0)
                    {
                        break;
                    }
                    long beesLeft = beehavies[index] - hornetsPower;
                    if (beehavies[index] != hornetsPower)
                    {
                        beehavies[index] = beesLeft;
                    }
                    else
                    {
                        beehavies.RemoveAt(index);
                        index--;
                    }
                    hornets.RemoveAt(0);
                }
                else
                {
                    beehavies.RemoveAt(index);
                    index--;
                }
            }
            if (beehavies.Count > 0)
            {
                Console.WriteLine(string.Join(" ",beehavies));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
            
        }
    }
}
