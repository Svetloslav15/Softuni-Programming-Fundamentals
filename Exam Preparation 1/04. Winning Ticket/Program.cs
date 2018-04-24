using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                int diezCount = 0;
                int monkeyCount = 0;
                int dollarCount = 0;
                int chovkiCount = 0;
                foreach (var symbol in ticket)
                {
                    switch (symbol)
                    {
                        case '$':dollarCount++;break;
                        case '@':monkeyCount++;break;
                        case '^':chovkiCount++;break;
                        case '#':diezCount++;break;
                    }
                }
                    if (dollarCount == 20)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10$ Jackpot!");
                        continue;
                    }
                    else if (monkeyCount == 20)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10@ Jackpot!");
                        continue;
                    }
                    else if (chovkiCount == 20)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10^ Jackpot!");
                        continue;
                    }
                    else if (diezCount == 20)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10# Jackpot!");
                        continue;
                    }
                int diezCountLeft = 0;
                int monkeyCountLeft = 0;
                int dollarCountLeft = 0;
                int chovkiCountLeft = 0;
                for (int i = 0; i <= ticket.Length / 2; i++)
                {
                    char symbol = ticket[i];
                    switch (symbol)
                    {
                        case '$': dollarCountLeft++; break;
                        case '@': monkeyCountLeft++; break;
                        case '^': chovkiCountLeft++; break;
                        case '#': diezCountLeft++; break;
                    }
                }
                int diezCountRight = 0;
                int monkeyCountRight = 0;
                int dollarCountRight = 0;
                int chovkiCountRight = 0;
                for (int i = ticket.Length / 2 + 1; i <= ticket.Length - 1; i++)
                {
                    char symbol = ticket[i];
                    switch (symbol)
                    {
                        case '$': dollarCountRight++; break;
                        case '@': monkeyCountRight++; break;
                        case '^': chovkiCountRight++; break;
                        case '#': diezCountRight++; break;
                    }
                }
                if (diezCountLeft >= 6 && diezCountRight >= 6 && diezCountLeft == diezCountRight)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {diezCountRight}#");
                }
                else if (dollarCountLeft >= 6 && dollarCountRight >= 6 && dollarCountLeft == dollarCountRight)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {dollarCountRight}$");
                }
                else if (chovkiCountLeft >= 6 && chovkiCountRight >= 6 && chovkiCountLeft == chovkiCountRight)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {chovkiCountRight}^");
                }
                else if (monkeyCountLeft >= 6 && monkeyCountRight >= 6 && monkeyCountLeft == monkeyCountRight)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {monkeyCountRight}@");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
