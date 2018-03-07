using System;

namespace _14._Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            int firstTiles = 0;
            int secondTiles = 0;
            bool haveWinner = false;

            for (int counter = 1; counter <= numberOfLines; counter++)
            {
                string wordsToIncreaseSpeed = Console.ReadLine();
                int count = 0;
                foreach(int item in wordsToIncreaseSpeed)
                {
                    count++;
                }
                if (wordsToIncreaseSpeed == "UPGRADE")
                {
                     secondBoat = (char)(secondBoat + 3);                  
                     firstBoat = (char)(firstBoat + 3);          
                     count = 0;
                }
                else if (counter % 2 == 0)
                {
                    secondTiles += count;
                    count = 0;
                }
                else if (counter % 2 != 0)
                {
                    firstTiles += count;
                    count = 0;
                }
                if (firstTiles >= 50)
                {
                    Console.WriteLine(firstBoat);
                    haveWinner = true;
                    break;
                }
                if (secondTiles >= 50)
                {
                    Console.WriteLine(secondBoat);
                    haveWinner = true;
                    break;
                }
            }
            if (!haveWinner)
            {
                if (firstTiles > secondTiles)
                {
                    Console.WriteLine(firstBoat);
                }
                else
                {
                    Console.WriteLine(secondBoat);
                }
            }
        }
    }
}
