using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeamsToRegister = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            

            for (int numberOfTeams = 1; numberOfTeams <= numberOfTeamsToRegister; numberOfTeams++)
            {
                string[] tokens = Console.ReadLine().Split('-').ToArray();
                string creator = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    
                }
                else
                {
                    if (teams.Any(x => x.Creator == creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                        
                    }
                    else
                    {
                        Team team = new Team();
                        team.Name = teamName;
                        team.Creator = creator;
                        List<string> members = new List<string>();
                        team.Members = members;

                        teams.Add(team);

                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {              
                string[] tokens = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string userName = tokens[0];
                string team = tokens[1];

                if (!teams.Any(x => x.Name == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else
                {
                    if (teams.Any(x => x.Creator == userName) || teams.Any(x => x.Members.Contains(userName)))
                    {
                        Console.WriteLine($"Member {userName} cannot join team {team}!");
                    }
                    else
                    {              
                        teams.First(x => x.Name == team).Members.Add(userName);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var team in teams.Where(x => x.Members.Count != 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var mem in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {mem}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
