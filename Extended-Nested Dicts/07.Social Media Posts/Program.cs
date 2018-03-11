using System;
using System.Collections.Generic;

namespace _07.Social_Media_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> post = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, List<string>> postAndComments = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "drop the media")
            {
                string[] tokens = input.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries );
                string command = tokens[0].Trim();
                string name = tokens[1].Trim();
                if (command == "post")
                {
                    post.Add(name, new Dictionary<string, int>());
                    postAndComments.Add(name, new List<string>());
                    post[name].Add("Likes", 0);
                    post[name].Add("Dislikes", 0);   
                }
                else if (command == "like")
                {
                    post[name]["Likes"]++;
                }
                else if (command == "dislike")
                {
                    post[name]["Dislikes"]++;
                }
                else
                {
                    string bla = Bla(tokens);
                    string comment = $"{tokens[2]}: {Bla(tokens).Trim()}";
                    postAndComments[name].Add(comment);
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in post)
            {
                Console.Write($"Post: {kvp.Key} ");
                foreach (var item in kvp.Value)
                {
                    Console.Write($"| {item.Key}: {item.Value} ");
                }
                Console.WriteLine();
                Console.WriteLine("Comments:");
                if (postAndComments[kvp.Key].Count == 0)
                {
                    Console.WriteLine("None");
                    continue;
                }
                foreach (var item in postAndComments)
                {
                    if (item.Key == kvp.Key)
                    {
                        for (int i = 0; i <= item.Value.Count - 1; i++)
                        {
                            Console.WriteLine($"*  {postAndComments[item.Key][i]}");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private static string Bla(string[] tokens)
        {
            string blabla = "";
            for (int i = 3; i < tokens.Length; i++)
            {
                blabla += $" {tokens[i]}";
            }
            return blabla;
        }
    }
}
