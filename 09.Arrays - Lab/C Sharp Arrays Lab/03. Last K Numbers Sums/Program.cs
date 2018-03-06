using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                long sum = 0;
                for(int pos = i - k; pos <= i - 1; pos++)
                {
                    if (pos >= 0)
                    {
                        sum += (long)numbers[pos];
                    }
                }
                numbers[i] = sum;

            }

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
