using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            bool equal = false;
            int counter = 0;


            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    counter++;
                    if ((i + j ) == magicalNum)
                    {
                        equal = true;
                        Console.WriteLine($"Number found! {j} + {i} = {i + j}");
                        break;
                    }
                }
               if (equal == true)
                {
                    break;
                }
            }
            if (equal == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNum}");
                
            }

        }
    }
}
