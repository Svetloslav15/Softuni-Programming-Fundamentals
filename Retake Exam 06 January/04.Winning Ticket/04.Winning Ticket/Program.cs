using System;
using System.Linq;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int index = 0; index < tickets.Length; index++)
            {
                string ticket = tickets[index];
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var firstHalf = ticket.Take(10).ToArray();
                    var secondHalf = ticket.Skip(10).Take(10).ToArray();

                    int countMonkeyA1 = CountMonkeyA(firstHalf);
                    int countMonkeyA2 = CountMonkeyA(secondHalf);
                    int countMonkey = countMonkeyA1 + countMonkeyA2;

                    int countDiez1 = CountDiez(firstHalf);
                    int countDiez2 = CountDiez(secondHalf);
                    int countDiez = countDiez1 + countDiez2;

                    int countDollars1 = CountDollars(firstHalf);
                    int countDollars2 = CountDollars(secondHalf);
                    int countDollars = countDollars1 + countDollars2;

                    int countChovki1 = CountChovki(firstHalf);
                    int countChovki2 = CountChovki(secondHalf);
                    int countChovki = countChovki1 + countChovki2;

                    if (Jackpot(ticket))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                    }
                    else if (countMonkeyA1 >= 6 && countMonkeyA2 >= 6)
                    {
                        double length = Math.Min(countMonkeyA1, countMonkeyA2);
                        Console.WriteLine($"ticket \"{ticket}\" - {length}@");
                    }
                    else if (countDiez1 >= 6 && countDiez2 >= 6)
                    {
                        double length = Math.Min(countDiez1, countDiez2);
                        Console.WriteLine($"ticket \"{ticket}\" - {length}#");
                    }
                    else if (countChovki1 >= 6 && countChovki2 >= 6)
                    {
                        double length = Math.Min(countChovki2, countChovki1);
                        Console.WriteLine($"ticket \"{ticket}\" - {length}^");
                    }
                    else if (countDollars1 >= 6 && countDollars2 >= 6)
                    {
                        double length = Math.Min(countDollars1, countDollars2);
                        Console.WriteLine($"ticket \"{ticket}\" - {length}$");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
        static bool Jackpot(string ticket)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            foreach (var item in ticket)
            {
                if (item == '@')
                {
                    count1++;
                }
                else if (item == '#')
                {
                    count2++;
                }
                else if (item == '$')
                {
                    count3++;
                }
                else if (item == '^')
                {
                    count4++;
                }
            }

            if (count1 == 20 || count2 == 20 || count3 == 20 || count4 == 20)
            {
                return true;
            }
            return false;
        }
        static int CountMonkeyA(char[] ticket)
        {
            int count = 0;
            foreach (var item in ticket)
            {
                if (item == '@')
                {
                    count++;
                }
            }
            return count;
        }

        static int CountDiez(char[] ticket)
        {
            int count = 0;
            foreach (var item in ticket)
            {
                if (item == '#')
                {
                    count++;
                }
            }
            return count;
        }
        static int CountDollars(char[] ticket)
        {
            int count = 0;
            foreach (var item in ticket)
            {
                if (item == '$')
                {
                    count++;
                }
            }
            return count;
        }
        static int CountChovki(char[] ticket)
        {
            int count = 0;
            foreach (var item in ticket)
            {
                if (item == '^')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
