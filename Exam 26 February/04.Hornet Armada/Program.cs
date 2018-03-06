namespace _04.Hornet_Armada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Hornet_Armada
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, long> legionAndActivity = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionAndSoldiers = new Dictionary<string, Dictionary<string, long>>();

            for (int line = 1; line <= numberOfLines; line++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                long legionActivity = long.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long soldierCount = long.Parse(tokens[3]);

                if (!legionAndActivity.ContainsKey(legionName))
                {
                    legionAndActivity.Add(legionName, legionActivity);
                }
                else
                {
                    if (legionAndActivity[legionName] < legionActivity)
                    {
                        legionAndActivity[legionName] = legionActivity;
                    }
                }

                if (!legionAndSoldiers.ContainsKey(legionName))
                {
                    legionAndSoldiers.Add(legionName, new Dictionary<string, long>());
                    legionAndSoldiers[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    if (!legionAndSoldiers[legionName].ContainsKey(soldierType))
                    {
                        legionAndSoldiers[legionName].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        legionAndSoldiers[legionName][soldierType] += soldierCount;
                    }
                }
            }

            string[] finalCommand = Console.ReadLine().Split('\\');

            if (finalCommand.Length == 1)
            {
                //soldierType
                foreach (var kvp in legionAndActivity.OrderByDescending(x => x.Value))
                {
                    if (legionAndSoldiers[kvp.Key].ContainsKey(finalCommand[0]))
                    {
                        Console.WriteLine($"{kvp.Value} : {kvp.Key}");
                    }
                }
            }
            else
            {
                //activity/soldierType
                int activity = int.Parse(finalCommand[0]);
                string type = finalCommand[1];

                foreach (var kvp in legionAndSoldiers
                    .Where(x => x.Value.ContainsKey(type))
                    .OrderByDescending(x => x.Value[type]))
                {
                    if (legionAndActivity[kvp.Key] < activity)
                    {
                        Console.WriteLine($"{kvp.Key} -> {legionAndSoldiers[kvp.Key][type]}");
                    }
                }

            }
            
        }
    }
}