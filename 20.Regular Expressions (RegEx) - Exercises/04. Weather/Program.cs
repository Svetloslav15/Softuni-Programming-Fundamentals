using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Weather> weathers = new List<Weather>();
            while (input != "end")
            {
                string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)(\|)";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                if (regex.IsMatch(input))
                {
                    foreach (Match item in matches)
                    {
                        string cityName = item.Groups[1].ToString();
                        double averageTemperature = double.Parse(item.Groups[2].ToString());
                        string weatherType = item.Groups[3].ToString();

                        if (weathers.Any(x => x.City == cityName))
                        {
                            weathers.First(x => x.City == cityName).City = cityName;
                            weathers.First(x => x.City == cityName).Temperature = averageTemperature;
                            weathers.First(x => x.City == cityName).Type = weatherType;
                        }
                        else
                        {
                            Weather weather = new Weather();
                            weather.City = cityName;
                            weather.Temperature = averageTemperature;
                            weather.Type = weatherType;
                            weathers.Add(weather);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var weather in weathers.OrderBy(x => x.Temperature).Distinct())
            {
                Console.WriteLine($"{ weather.City} => {weather.Temperature:f2} => {weather.Type}");
            }
        }
    }
    class Weather
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public string Type { get; set; }
    }
}
