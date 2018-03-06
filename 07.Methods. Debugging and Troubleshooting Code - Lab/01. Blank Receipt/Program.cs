using System;

namespace _01._Blank_Receipt
{
    class Program
    {
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void Main()
        {
            PrintReceipt();
        }
    }
}
