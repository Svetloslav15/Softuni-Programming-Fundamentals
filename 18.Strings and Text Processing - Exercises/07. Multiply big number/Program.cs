using System;
using System.Linq;
using System.Text;

namespace _07._Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());
            
            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();
            int reminders = 0;

            for (int index = 0; index <= number.Length - 1; index++)
            {
                int num = number[number.Length - 1 - index] - 48;
                int result = num * multiplier + reminders;
                sb.Append(result % 10);
                reminders = result / 10;
            }

            if (reminders != 0)
            {
                sb.Append(reminders);
            }

            Console.WriteLine(string.Concat(sb.ToString().Reverse()));
        }
    }
}
