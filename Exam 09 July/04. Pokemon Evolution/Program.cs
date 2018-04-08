using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Pokemon> pokemons = new List<Pokemon>();

            while (input != "wubbalubbadubdub")
            {
                string[] tokens = input.Split(" -> ");
                if (tokens.Length == 1)
                {
                    if (pokemons.Any(x => x.Name == tokens[0]))
                    {
                        foreach (var pok in pokemons)
                        {
                            if (pok.Name == tokens[0])
                            {
                                Console.WriteLine($"# {pok.Name}");
                                foreach (var pokemon in pok.Property)
                                {
                                    Console.WriteLine($"{pokemon.Type} <-> {pokemon.Index}");
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    string name = tokens[0];
                    string type = tokens[1];
                    int index = int.Parse(tokens[2]);

                    Property property = new Property(type, index);

                    Pokemon pokemon = new Pokemon();
                    pokemon.Name = name;
                    pokemon.Property = new List<Property>();
                    pokemon.Property.Add(property);
                    if (!pokemons.Any(x => x.Name == name))
                    {
                        pokemons.Add(pokemon);
                    }
                    else
                    {
                        int i = pokemons.FindIndex(x => x.Name == name);
                        pokemons[i].Property.Add(property);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Name}");
                foreach (var pok in pokemon.Property.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{pok.Type} <-> {pok.Index}");
                }
            }
        }
    }

    class Pokemon
    {
        public string Name { get; set; }
        public List<Property> Property { get; set; }
    }
    class Property
    {
        public string Type { get; set; }
        public int Index { get; set; }
        public Property(string type, int index)
        {
            Type = type;
            Index = index;
        }
    }
}
