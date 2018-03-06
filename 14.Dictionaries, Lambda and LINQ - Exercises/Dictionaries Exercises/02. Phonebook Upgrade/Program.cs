using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
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
                else if (phone[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                phone = Console.ReadLine().Split(' ').ToArray();
            }

        }
    }
}
