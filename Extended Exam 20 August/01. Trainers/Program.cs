using System;

namespace _01._Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberOfParticipants = decimal.Parse(Console.ReadLine());

            string finalTeam = "";

            decimal technical = 0.0m;
            decimal theorical = 0.0m;
            decimal practical = 0.0m;

            for (int i = 1; i <= numberOfParticipants; i++)
            {
                decimal distanceInMiles = decimal.Parse(Console.ReadLine()) * 1600;
                decimal cargoInTones = decimal.Parse(Console.ReadLine()) * 1000;
                string team = Console.ReadLine();

                decimal money = (cargoInTones * 1.5m) - (0.7m * distanceInMiles * 2.5m);
                switch (team)
                {
                    case "Technical": technical += money; break;
                    case "Practical": practical += money; break;
                    case "Theoretical": theorical += money; break;
                }
            }
            decimal max = Math.Max(practical, Math.Max(theorical, technical));

            if (technical == max)
            {
                Console.WriteLine($"The Technical Trainers win with ${technical:F3}.");
            }
            if (theorical == max)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theorical:F3}.");
            }
            if (practical == max)
            {
                Console.WriteLine($"The Practical Trainers win with ${practical:F3}.");
            }
        }
    }
}
