using System;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            string reversed = ReversedInputNum(inputNum);
            Console.WriteLine(reversed);
        }

        static string ReversedInputNum(string inputNum)
        {
            string reversed = null;

            for (int i = inputNum.Length - 1; i >= 0; i--)
            {
                reversed += inputNum[i];

            }
            return reversed;
        }        
       
    }
}
