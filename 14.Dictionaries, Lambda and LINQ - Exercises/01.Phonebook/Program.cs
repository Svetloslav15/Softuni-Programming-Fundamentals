using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] phone = Console.ReadLine().Split(' ').ToArray();

            while (phone[0] != "END")
            {
                if (phone[0] == "A")
                {
                    phonebook[phone[1]] = phone[2];
                }
                else if (phone[0] == "S")
                {
                    if (phonebook.ContainsKey(phone[1]))
                    {
                        Console.WriteLine($"{phone[1]} -> {phonebook[phone[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {phone[1]} does not exist.");
                    }
                }
                phone = Console.ReadLine().Split(' ').ToArray();
            }

        }
    }
}
