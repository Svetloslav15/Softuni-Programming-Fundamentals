using System;
using System.Linq;

namespace _02._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] result = new int[length];

            int bestLength = 0;
            int bestIndex = 0;
            int counter = 1;
            int seqIndex = 1;

            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int[] temp = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int tempLength = 0;
                int tempIndex = 0;

                for (int index = 0; index < temp.Length; index++)
                {
                    if (temp[index] == 1)
                    {
                        tempLength++;
                        if (tempLength > bestLength)
                        {
                            result = temp;
                            bestLength = tempLength;
                            bestIndex = tempIndex;
                            seqIndex = counter;
                        }
                        else if (tempLength == bestLength)
                        {
                            if (tempIndex < bestIndex)
                            {
                                result = temp;
                                bestLength = tempLength;
                                bestIndex = tempIndex;
                                seqIndex = counter;
                            }

                            else if (tempIndex == bestIndex && temp.Sum() > result.Sum())
                            {
                                result = temp;
                                bestLength = tempLength;
                                bestIndex = tempIndex;
                                seqIndex = counter;
                            }
                        }                    
                    }
                else
                {
                    tempLength = 0;
                    tempIndex = index + 1;
                }
                }
                counter++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {seqIndex} with sum: {result.Sum()}.");
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
