using System;

namespace _01.Band_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            int membersCount = int.Parse(Console.ReadLine());
            double guitarPrice = double.Parse(Console.ReadLine());

            int guitarists = (int)Math.Floor((decimal)(1 / 3.0 * membersCount));
            int drumers = membersCount - guitarists - 1;

            double drumPrice = guitarPrice + 0.5 * guitarPrice;
            double microfonePrice = drumers * drumPrice - guitarists * guitarPrice;
            double average = (drumPrice * drumers + microfonePrice + guitarPrice * guitarists) / membersCount;

            double allPrice = drumPrice * drumers + microfonePrice + guitarPrice * guitarists + average * 12;

            Console.WriteLine($"Total cost: {allPrice:f2}lv.");
        }
    }
}
