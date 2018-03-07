using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string healthPattern = @"[^\d*\/\+\-\.]";
            string damagePattern = @"\-*(\d+)(\.*)(\d+)*";
            string divOrMulattern = @"[*]*[\/]*";

            List<Demon> demonsCatalog = new List<Demon>();

            for (int index = 0; index <= demons.Length - 1; index++)
            {
                MatchCollection matches = Regex.Matches(demons[index], healthPattern);
                int health = CalculateHealth(matches);
                MatchCollection secondMatches = Regex.Matches(demons[index], damagePattern);
                double damage = CalculateDamage(secondMatches);
                MatchCollection dem = Regex.Matches(demons[index], divOrMulattern);
                damage = CalculateDamageMulOrDiv(dem, damage);

                Demon demon = new Demon();
                demon.Name = demons[index];
                demon.Health = health;
                demon.Damage = damage;

                demonsCatalog.Add(demon);
            }

            foreach (Demon dem in demonsCatalog.OrderBy(X => X.Name))
            {
                Console.WriteLine($"{dem.Name} - {dem.Health} health, {dem.Damage:F2} damage");
            }
        }

        static double CalculateDamageMulOrDiv(MatchCollection dem, double damage)
        {
            foreach (Match item in dem)
            {
                int numberOfSymbols = item.Value.ToString().Length;
                string itemAsText = item.Value.ToString();

                for (int i = 0; i <= itemAsText.Length - 1; i++)
                {
                    if (itemAsText[i] == '*')
                    {
                        damage *= 2;
                    }
                    else if (itemAsText[i] == '/')
                    {
                        damage /= 2;
                    }
                }
            }
            return damage;
        }

        static double CalculateDamage(MatchCollection matches)
        {
            double damage = 0.0;
            foreach (Match item in matches)
            {
                if (item.Value == "*")
                {
                    damage *= 2;
                }
                else if (item.Value == "/")
                {
                    damage /= 2;
                }
                else
                {
                    damage += double.Parse(item.Value.ToString());
                }
            }
            return damage;
        }

        static int CalculateHealth(MatchCollection matches)
        {
            int health = 0;
            foreach (Match item in matches)
            {
                char[] letter = item.Value.ToCharArray();
                health += letter[0];
            }
            return health;
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
}
