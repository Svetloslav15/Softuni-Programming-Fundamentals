using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                string[] split = { " <-> " };
                string spliter = " -> ";
                string[] tokens = input.Split(split, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length >= 2)
                {
                    if (tokens[0].All(x => char.IsDigit(x)) && (tokens[1].All(x => char.IsLetterOrDigit(x))))
                    {
                        //it is a message
                        string recepientCode = Reverse(tokens[0]);
                        string message = tokens[1];
                        string finalMessage = recepientCode + spliter + message;
                        messages.Add(finalMessage);
                    }
                    else if (tokens[0].All(x => !char.IsDigit(x)) && (tokens[1].All(x => char.IsLetterOrDigit(x))))
                    {
                        //it is a broadcast
                        string message = tokens[0];
                        string frequency = tokens[1];
                        frequency = ChangeCapitalAndSmallLetters(frequency);
                        string finalBroadcast = frequency + spliter + message;
                        broadcasts.Add(finalBroadcast);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in messages)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static string ChangeCapitalAndSmallLetters(string frequency)
        {
            char[] temp = new char[frequency.Length];
            for (int index = 0; index < frequency.Length; index++)
            {
                if (char.IsLower(frequency[index]))
                {
                    temp[index] = char.ToUpper(frequency[index]);
                }
                else if (char.IsUpper(frequency[index]))
                {
                    temp[index] = char.ToLower(frequency[index]);
                }
                else
                {
                    temp[index] = frequency[index];
                }
            }
            frequency = new string(temp);
            return frequency;
        }

        static string Reverse(string text)
        {
            char[] temp = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                temp[i] = text[text.Length - 1 - i];
            }

            text = new string(temp);
            return text;
        }
    }
}