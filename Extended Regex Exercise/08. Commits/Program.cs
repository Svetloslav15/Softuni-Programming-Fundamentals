using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _08._Commits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // user -> repo -> 
            var dict = new Dictionary<string, List<Repository>>();
            string pattern = @"https:\/\/github\.com\/(?<user>[a-zA-Z0-9\-]+)\/(?<repo>[A-Za-z\-]+)\/commit\/(?<hash>[0-9ABCDEFabcdef]{40}),(?<message>[^\n]+),(?<additions>[0-9]+),(?<deletions>[0-9]+)";

            while (input != "git push")
            {
                Match match = Regex.Match(input, pattern);
                string user = match.Groups["user"].Value;
                string repo = match.Groups["repo"].Value;
                string hash = match.Groups["hash"].Value;
                string message = match.Groups["message"].Value;
                int additions = int.Parse(match.Groups["additions"].Value);
                int deletions = int.Parse(match.Groups["deletions"].Value);

                string commit = $"commit {hash}: {message} ({additions} additions, {deletions} deletions)";

                if (!dict.ContainsKey(user))
                {
                    dict.Add(user, new List<Repository>());
                }
                Repository anon = new Repository();
                anon.Name = repo;
                anon.Commits = new List<string>();
                anon.Commits.Add(commit);
                anon.Additions = additions;
                anon.Deletions = deletions;
                dict[user].Add(anon);
                input = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var repos in kvp.Value)
                {
                    int addAll = 0;
                    int delAll = 0;
                    foreach (var item in kvp.Value)
                    {
                        addAll += item.Additions;
                        delAll += item.Deletions;
                    }
                    Console.WriteLine($"  {repos.Name}:");
                    foreach (var com in repos.Commits)
                    {
                        Console.WriteLine($"    {com}");
                    }
                    Console.WriteLine($"Total: {addAll} additions, {delAll} deletions");
                }
            }
        }
    }

    class Repository
    {
        public string Name { get; set; }
        public List<string> Commits { get; set; }
        public int Additions { get; set; }
        public int Deletions { get; set; }
    }
}
