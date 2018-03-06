using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<Dwarf>> dwarfs = new Dictionary<string, List<Dwarf>>();
            List<Dwarf> allDwarfs = new List<Dwarf>();

            while (input != "Once upon a time")
            {
                string[] tokens = input.Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = tokens[0];
                string hatColor = tokens[1];
                int physics = int.Parse(tokens[2]);
                
                if (!dwarfs.ContainsKey(hatColor))
                {
                    dwarfs.Add(hatColor, new List<Dwarf>());
                }

                List<Dwarf> dwarfsByCurrentColor = dwarfs[hatColor];
                Dwarf currentDwarf = dwarfsByCurrentColor.FirstOrDefault(x => x.Name == dwarfName);

                if (currentDwarf != null)
                {
                    currentDwarf.Physics = Math.Max(physics, currentDwarf.Physics);
                }
                else
                {
                    Dwarf dwarf = new Dwarf();
                    dwarf.Name = dwarfName;
                    dwarf.HatColor = hatColor;
                    dwarf.Physics = physics;
                    dwarfs[hatColor].Add(dwarf);
                    allDwarfs.Add(dwarf);
                }
                input = Console.ReadLine();
            }

            var result = allDwarfs
                .OrderByDescending(x => x.Physics)
                .ThenByDescending(x => dwarfs[x.HatColor].Count())
                .ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"({item.HatColor}) {item.Name} <-> {item.Physics}");
            }
        }
    }
}
