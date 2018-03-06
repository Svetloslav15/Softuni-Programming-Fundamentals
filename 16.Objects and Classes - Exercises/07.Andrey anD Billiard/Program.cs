using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Andrey_anD_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMenuItems = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            List<Customer> guests = new List<Customer>();

            for (int itemsNum = 1; itemsNum <= numberOfMenuItems; itemsNum++)
            {
                string[] menuInfo = Console.ReadLine().Split('-');
                string productName = menuInfo[0];

                decimal productPrice = decimal.Parse(menuInfo[1]);
                if (!menu.ContainsKey(productName))
                {
                    menu.Add(productName, productPrice);
                }
                else
                {
                    menu[productName] = productPrice;
                }
            }
            string order = Console.ReadLine();

            while (order != "end of clients")
            {
                string[] orderInfo = order.Split('-');
                string customerName = orderInfo[0];
                string[] temp = orderInfo[1].Split(',');
                string itemWanted = temp[0];
                int quantity = int.Parse(temp[1]);


                if (!menu.ContainsKey(itemWanted))
                {
                    order = Console.ReadLine();
                    continue;
                }
                else
                {
                    Dictionary<string, int> customerShopList = new Dictionary<string, int>();
                    customerShopList.Add(itemWanted, quantity);
                    decimal billPrice = menu[itemWanted] * quantity;
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    customer.ProductsAndQunatity = customerShopList;
                    customerShopList[itemWanted] = quantity;
                    customer.Bill += billPrice;


                    if (guests.Any(x => x.Name == customerName))
                    {
                        Customer currentCustomer = guests.First(x => x.Name == customerName);

                        if (currentCustomer.ProductsAndQunatity.ContainsKey(itemWanted))
                        {
                            currentCustomer.ProductsAndQunatity[itemWanted] += quantity;
                            currentCustomer.Bill += menu[itemWanted] * quantity;
                        }
                        else
                        {
                            currentCustomer.ProductsAndQunatity[itemWanted] = quantity;
                            currentCustomer.Bill += menu[itemWanted] * quantity;
                        }
                    }
                    else
                    {
                        guests.Add(customer);
                    }
                }

                order = Console.ReadLine();
            }
            decimal totalPrice = 0.0m;
            foreach (var customer in guests.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.ProductsAndQunatity)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                totalPrice += customer.Bill;
                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {totalPrice:F2}");
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductsAndQunatity { get; set; }
        public decimal Bill { get; set; }
    }
}
