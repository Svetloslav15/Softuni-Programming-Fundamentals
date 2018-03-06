using System;

namespace _05._Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();
            bool yes = Convert.ToBoolean(boolean);
            if (yes)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }

        }
    }
}
