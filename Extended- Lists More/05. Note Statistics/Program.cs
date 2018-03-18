using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                .Split()
                .Select(x => double.Parse(x))
                .ToList();

            List<string> notes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            double naturalSum = 0.0;
            double sharpSum = 0.0;

            for (int index = 0; index <= nums.Count - 1; index++)
            {
                Console.Beep((int)nums[index], 159);
                string musicalNote = (MusicalNote(nums[index])).ToString();
                notes.Add(musicalNote);
                if (musicalNote == "C#" ||
                    musicalNote == "D#" ||
                    musicalNote == "F#" ||
                    musicalNote == "G#" ||
                    musicalNote == "A#")
                {
                    sharps.Add(musicalNote);
                    sharpSum += nums[index];
                }
                else
                {
                    naturals.Add(musicalNote);
                    naturalSum += nums[index];
                }
            }

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            Console.WriteLine($"Naturals sum: {string.Join(" ", naturalSum)}");
            Console.WriteLine($"Sharps sum: {string.Join(" ", sharpSum)}");
        }

        static string MusicalNote(double num)
        {
            string musicalNote = "";
            switch (num)
            {
                case 261.63:musicalNote = "C";break;
                case 277.18:musicalNote = "C#";break;
                case 293.66:musicalNote = "D";break;
                case 311.13:musicalNote = "D#";break;
                case 329.63:musicalNote = "E";break;
                case 349.23:musicalNote = "F";break;
                case 369.99:musicalNote = "F#";break;
                case 392.00:musicalNote = "G";break;
                case 415.30:musicalNote = "G#";break;
                case 440.00:musicalNote = "A";break;
                case 466.16:musicalNote = "A#";break;
                case 493.88:musicalNote = "B";break;
                default:
                    break;
            }
            return musicalNote;
        }
    }
}