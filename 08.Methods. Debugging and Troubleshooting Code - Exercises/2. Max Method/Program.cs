using System;

namespace _2._Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(firstNum, secondNum, thirdNum));
        }
        static int GetMax(int firstNum, int secondNum, int thirdNum)
        {
            int max = firstNum;
            if (firstNum >= secondNum && firstNum > thirdNum)
            {
                max = firstNum;
            }
            else if (secondNum >= firstNum && secondNum > thirdNum)
            {
                max = secondNum;
            }
            else if (thirdNum >= firstNum && thirdNum > secondNum)
            {
                max = thirdNum;
            }
            else if (firstNum == secondNum && firstNum == thirdNum)
            {
                max = firstNum;
            }
            else if (secondNum >= thirdNum && secondNum > firstNum)
            {
                max = secondNum;
            }

            return max;
        }
    }
}
