using System;
using System.Collections.Generic;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int counter = 1;
            string name = "";
            string[] email = new string[2];
            Dictionary<string, string> mail = new Dictionary<string, string>();

            while (command != "stop")
            {
                if (counter % 2 == 0)
                {
                    email = command.Split('.');
                    if ((email[1] != "uk") && (email[1] != "us"))
                    {
                        string word = email[0] + "." + email[1];
                        mail.Add(name, word);
                    }
                    
                }
                else
                {
                    name = command;
                }
                command = Console.ReadLine();
                counter++;
            }

            foreach (var item in mail)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
