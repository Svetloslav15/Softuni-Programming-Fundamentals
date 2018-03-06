using System;

namespace _12._Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                if (((IsSymetric(currentNumber)) && (HaveEvenDigit(currentNumber)) && (SumOfDigits(currentNumber) % 7 == 0)))
                Console.WriteLine(currentNumber);            
            }
        }

        static bool IsSymetric(int number)
        {
            int reversed = 0;
            bool equal = false;
            int copy = number;
            
            while(copy != 0)
            {
                reversed = reversed * 10 + copy % 10;
                copy /= 10;
            }
        
            if (number == reversed)
            {
                equal = true;
            }
            return equal;
        }
        
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
        
            return sum;
        }
        
        static bool HaveEvenDigit(int number)
        {
            bool haveEvenDigit = false;
            while(number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    haveEvenDigit = true;
                    break;
                }
                number /= 10;
            }
            return haveEvenDigit;
        }
    }
}
