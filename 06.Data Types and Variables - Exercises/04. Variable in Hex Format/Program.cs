using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string c = Console.ReadLine();
            double b = Convert.ToInt16(c, 16);

            Console.WriteLine(b);

        }
    }
}
