using System;

namespace _02._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Random random = new Random();

            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            for (int numberOfAdvertisments = 1; numberOfAdvertisments <= number; numberOfAdvertisments++)
            {
                int phrasesIndex = random.Next(0, phrases.Length);
                int eventIndex = random.Next(0, events.Length);
                int authorIndex = random.Next(0, authors.Length);
                int cityIndex = random.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phrasesIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[cityIndex]}");
            }
        }
    }
}
