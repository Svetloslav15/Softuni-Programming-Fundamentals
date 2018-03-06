using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool yes = false;


            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            for (int h = a; h <= b; h++)
                            {
                                if ((a <= i) && ((j > i) && (j < k)) && ((k > j) && (k < l)) && ((l > k) && (l < h)) && ((h > l) && (h <= b)))
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {h}");
                                    yes = true;
                                }
                            }
                        }
                    }
                }
            }
                if (!yes)
                {
                    Console.WriteLine("No");
                }
        }
    }
}
