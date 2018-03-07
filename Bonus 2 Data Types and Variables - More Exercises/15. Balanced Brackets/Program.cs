using System;

namespace _15._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int firstBalanced = 0;
            int secondBalanced = 0;
            bool balanced = true;
            bool has = false;


            for (int counter = 1; counter <= numberOfLines; counter++)
            {
                string input = Console.ReadLine();
                if (has && input == "(")
                {
                    Console.WriteLine("UNBALANCED");
                    balanced = false;
                    break;
                }
                else
                {
                    has = false;
                }
                if (input == "()")
                {
                    Console.WriteLine("UNBALANCED");
                    balanced = false;
                    break;
                }
                if (input == "(")
                {
                    firstBalanced++;
                    has = true;
                }
                else if (input == ")")
                {
                    secondBalanced++;
                }
                if (input == "(" && counter == numberOfLines)
                {
                    Console.WriteLine("UNBALANCED");
                    balanced = false;
                    break;
                }


            }
            if (balanced)
            {
                if (firstBalanced == secondBalanced)
                {
                    Console.WriteLine("BALANCED");
                }
                else
                {
                    Console.WriteLine("UNBALANCED");
                }


            }
        }
    }
}