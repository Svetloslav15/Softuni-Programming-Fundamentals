using System;

namespace _03._English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            long lastDigit = num % 10;
            string lastDigitInText = GetLastDigit(lastDigit);
            Console.WriteLine(lastDigitInText);
        }

        static string GetLastDigit(long lastDigit)
        {
            string name = null;
            switch (Math.Abs(lastDigit))
            {
                case 0: name = "zero";break;
                case 1: name = "one";break;
                case 2: name = "two";break;
                case 3: name = "three";break;
                case 4: name = "four";break;
                case 5: name = "five";break;
                case 6: name = "six";break;
                case 7: name = "seven";break;
                case 8: name = "eight";break;
                case 9: name = "nine";break;
              
            }

            return name;
        }
    }
}
