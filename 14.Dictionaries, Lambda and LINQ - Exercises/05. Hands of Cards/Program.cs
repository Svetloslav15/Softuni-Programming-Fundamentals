using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while(input != "JOKER")
            {
                string[] args = input.Split(':');
                string name = args[0];
                string[] cards = args[1].Trim().Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in cards)
                {
                    if (!people.ContainsKey(name))
                    {
                        people.Add(name, new Dictionary<string, int>());
                        AddCardsToPerson(people[name], cards);
                    }
                    else
                    {
                        AddCardsToPerson(people[name], cards);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()}");
            }
        }

        static void AddCardsToPerson(Dictionary<string, int> name, string[] cards)
        {
            foreach (var card in cards)
            {
                if (!name.ContainsKey(card))
                {
                    name.Add(card, GetValue(card));
                }
            }
        }

        static int GetValue(string card)
        {
            int power = 0;
            switch (card[0])
            {
                case '1':power = 10;break;
                case '2':power = 2;break;
                case '3':power = 3;break;
                case '4':power = 4;break;
                case '5':power = 5;break;
                case '6':power = 6;break;
                case '7':power = 7;break;
                case '8':power = 8;break;
                case '9':power = 9; break;
                case 'J':power = 11;break;
                case 'Q':power = 12;break;
                case 'K':power = 13;break;
                case 'A': power = 14;break;
            }
            switch (card[card.Length - 1])
            {
                case 'S': power *= 4;break;
                case 'H': power *= 3;break;
                case 'D': power *= 2;break;
                case 'C': power *= 1;break;
            }
            return power;
        }
    }
}
