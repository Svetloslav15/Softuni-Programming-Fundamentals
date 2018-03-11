using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<BankAccount> bankAccounts = new List<BankAccount>();

            while (input != "end")
            {
                string[] tokens = input.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string bank = tokens[0];
                string name = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                BankAccount bankAccount = new BankAccount();
                bankAccount.Bank = bank;
                bankAccount.Name = name;
                bankAccount.Balance = balance;
                bankAccounts.Add(bankAccount);

                input = Console.ReadLine();
            }

            foreach (var bankAccount in bankAccounts.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{bankAccount.Name} -> {bankAccount.Balance} ({bankAccount.Bank})");
            }
        }
    }

    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }
}
