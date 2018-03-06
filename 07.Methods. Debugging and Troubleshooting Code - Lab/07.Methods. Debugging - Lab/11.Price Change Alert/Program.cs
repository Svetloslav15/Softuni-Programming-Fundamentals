using System;

namespace _11.Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double border = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine());
                double difference = Proc(price, nextPrice);
                bool isSignificantDifference = HaveDifference(difference, border);
                string message = Get(nextPrice, price, difference, isSignificantDifference);
                Console.WriteLine(message);

                price = nextPrice;
            }
        }

        private static string Get(double nextPrice, double price, double difference, bool etherTrueOrFalse)
        {
            string output = "";
            if (difference == 0)
            {
                output = string.Format("NO CHANGE: {0}", nextPrice);
            }
            else if (!etherTrueOrFalse)
            {
                output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100.0);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100.0);
            }
            else if (etherTrueOrFalse && (difference < 0))
            {
                output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100.0);
            }

            return output;
        }
        private static bool HaveDifference(double border, double isDiff)
        {
            if (Math.Abs(border) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double l, double c)
        {
            double r = (c - l) / l;
            return r;
        }
    }

}

