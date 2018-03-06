using System;
using System.Linq;
using System.Text;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine().TrimStart('0');
            string secondNum = Console.ReadLine().TrimStart('0');

            int reminders = 0;
            int result = 0;

            StringBuilder sb = new StringBuilder();
            int minLength = Math.Min(firstNum.Length, secondNum.Length);
            int maxLength = Math.Max(firstNum.Length, secondNum.Length);

            for (int i = 0; i <= minLength - 1; i++)
            {
                int firstChar = firstNum[firstNum.Length - 1 - i] - 48;
                int secondChar = secondNum[secondNum.Length - 1 - i] - 48;

                result = (firstChar + secondChar + reminders) ;
                reminders = result / 10;
                sb.Append(result % 10);
            }

            for (int i = 0; i <= maxLength - minLength - 1; i++)
            {
                if (firstNum.Length > secondNum.Length)
                {
                    result = firstNum[firstNum.Length - minLength - 1 - i] - 48 + reminders;
                    sb.Append(result % 10);
                    reminders = result / 10;
                }
                else
                {
                    result = secondNum[secondNum.Length - minLength - 1 - i] - 48 + reminders;
                    sb.Append(result % 10);
                    reminders = result / 10;
                }
            }
            if (reminders != 0)
            {
                sb.Append(reminders);
            }

            Console.WriteLine(string.Concat(sb.ToString().Reverse()));
        }
    }
}
