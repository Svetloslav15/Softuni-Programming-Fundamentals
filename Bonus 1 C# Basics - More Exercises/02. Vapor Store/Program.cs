using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double totalSum = budget;

            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        if (totalSum >= 39.99)
                        {
                            totalSum -= 39.99;
                            Console.WriteLine($"Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "CS: OG":
                        if (totalSum >= 15.99)
                        {
                            totalSum -= 15.99;
                            Console.WriteLine($"Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        if (totalSum >= 19.99)
                        {
                            totalSum -= 19.99;
                            Console.WriteLine($"Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Honored 2":
                        if (totalSum >= 59.99)
                        {
                            totalSum -= 59.99;
                            Console.WriteLine($"Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch":
                        if (totalSum >= 29.99)
                        {
                            totalSum -= 29.99;
                            Console.WriteLine($"Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (totalSum >= 39.99)
                        {
                            totalSum -= 39.99;
                            Console.WriteLine($"Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (totalSum <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                game = Console.ReadLine();
            }
            var total = budget - totalSum;
            Console.WriteLine($"Total spent: ${total:F2}. Remaining: ${totalSum:F2}");
        }
    }
}