using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random random = new Random();

            for (int index = 0; index <= words.Length - 1; index++)
            {
                string currentWord = words[index];
                int randomIndex = random.Next(0, words.Length - 1);
                string randomWord = words[randomIndex];

                words[index] = randomWord;
                words[randomIndex] = currentWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
