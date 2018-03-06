using System;

namespace _15._Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());
            int PeshoHealth = 100;
            int GoshoHealth = 100;
            int runds = 0;
            string winner = null;
            bool stop = false;
            

            for (int i = 0; i <= 100; i++)
            {
                GoshoHealth -= PeshoDamage;
                runds++;
                if (GoshoHealth <= 0)
                {
                    stop = true;
                    winner = "Pesho";
                    break;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                if (runds % 3 == 0)
                {
                    GoshoHealth += 10;
                    PeshoHealth += 10;
                }
                PeshoHealth -= GoshoDamage;
                runds++;
                if (PeshoHealth <= 0)
                {
                    stop = true;
                    winner = "Gosho";
                    break;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                if (runds % 3 == 0)
                {
                    GoshoHealth += 10;
                    PeshoHealth += 10;
                }
                
            }

            Console.WriteLine($"{winner} won in {runds}th round.");
        }
    }
}
