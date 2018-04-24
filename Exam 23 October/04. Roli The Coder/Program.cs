using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern = @"^(?<id>\d+)\s*#(?<name>\w+)\s*(?<participants>(@[\w]+\s*)*)$";
            Dictionary<string, Event> events = new Dictionary<string, Event>();

            while (input != "Time for Code")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string id = match.Groups["id"].Value;
                    string eventName = match.Groups["name"].Value;
                    List<string> participants = match.Groups["participants"].Value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                    if (!events.ContainsKey(id))
                    {
                        if (!events.Keys.Contains(eventName))
                        {
                            events.Add(id, new Event(eventName, participants));
                        }
                    }
                    else if (events[id].Name == eventName)
                    {
                        events[id].Participants.AddRange(participants);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var ev in events)
            {
                ev.Value.Participants = ev.Value.Participants.Distinct().ToList();
            }

            foreach (var kvp in events.Distinct().OrderByDescending(x => x.Value.Participants.Count).ThenBy(x => x.Value.Name))
            {
                Console.WriteLine($"{kvp.Value.Name} - {kvp.Value.Participants.Count}");
                foreach (var p in kvp.Value.Participants.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine(p);
                }
            }
        }

        class Event
        {
            public string Name { get; set; }
            public List<string> Participants { get; set; }
            public Event(string name, List<string> participants)
            {
                Name = name;
                Participants = participants;
            }
        }

    }
}