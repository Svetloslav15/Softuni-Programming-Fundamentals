using System;

namespace _08._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int counter = 1;
            int counter2 = 0;
            int sum = 1;
                
            while (n >= counter)
            {
                int num = 1 + counter2;
                Console.WriteLine(num);
               
                counter++;
                sum += num;
                counter2 += 2;
            }
            Console.WriteLine($"Sum: {sum - 1}");
        }
    }
}
