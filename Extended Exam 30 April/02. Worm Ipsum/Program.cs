using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Worm Ipsum")
            {
                string[] tokens = input.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 1 && tokens[0][0] >= 'A' && tokens[0][0] <= 'Z')
                {
                    string[] words = tokens[0].Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                    char symbol = ' ';
                    int length = 0;
                    bool stop = false;

                    for (int i = 0; i <= words.Length - 1; i++)
                    {
                        stop = false;
                        int max = 0;
                        for (int j = 0; j <= words[i].Length - 1; j++)
                        {
                            int temp = 0;
                            for (int k = j + 1; k <= words[i].Length - 1; k++)
                            {

                                if (words[i][j] == words[i][k] && words[i].Length > 1)
                                {
                                    temp++;
                                    if (temp > max)
                                    {
                                        symbol = words[i][j];
                                        length = words[i].Length;
                                        max = temp;
                                        stop = true;
                                    }
                                }
                            }
                        }
                        if (stop)
                        {
                            string newText = new string(symbol, length);
                            tokens[0] = tokens[0].Replace(words[i], newText);
                        }
                    }

                    Console.WriteLine(tokens[0] + '.');
                
                }

                input = Console.ReadLine();
            }
        }
    }
}
