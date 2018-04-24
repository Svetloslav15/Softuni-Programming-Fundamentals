using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.First_Album
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string namePattern = @"\[(?<value>[^-\s][a-zA-Z\s\-]+[^-\s])\]";
            string lyricsPattern = "\"(?<value>[a-zA-Z\\s]+)\"";
            string lengthPattern = @"([0-9]+s)|([0-9]+\:[0-9]+m)";
            int validSongs = 0;

            while (input != "Rock on!" && validSongs < 4)
            {
                Match nameMatch = Regex.Match(input, namePattern);
                Match lyricsMatch = Regex.Match(input, lyricsPattern);
                Match lengthMatch = Regex.Match(input, lengthPattern);

                if (nameMatch.Success && lyricsMatch.Success && lengthMatch.Success)
                {
                    string name = nameMatch.Groups["value"].Value;
                    string lyrics = lyricsMatch.Groups["value"].Value;
                    string length = lengthMatch.Value;
                    string answer = null;
                    
                    if (length.Contains('s'))
                    {
                        length = length.Remove(length.Length - 1);
                        int secs = int.Parse(length);
                        TimeSpan t = TimeSpan.FromSeconds(secs);
                        answer = string.Format($"{name} -> {t.Minutes:d2}:{t.Seconds:d2} => {lyrics}");
                        Console.WriteLine(answer);
                        validSongs++;
                    }
                    else
                    {
                        length = length.Remove(length.Length - 1);
                        int[] prop = length.Split(':').Select(int.Parse).ToArray();
                        answer = string.Format($"{name} -> {prop[0]:d2}:{prop[1]:d2} => {lyrics}");
                        Console.WriteLine(answer);
                        validSongs++;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
