using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            decimal result = 0.0m;

            foreach (var word in input)
            {
                char before = word[0];
                char after = word[word.Length - 1];
                char[] text = word.Skip(1).Take(word.Length - 2).ToArray();
                decimal a = Num(text);
                
                if (char.IsLower(before))
                {
                    result += (before - 96) * a;
                }
                else if (char.IsUpper(before))
                {
                    result += a / (before - 64);
                }

                if (char.IsUpper(after))
                {
                    result = result - (after - 64);
                }
                else if (char.IsLower(after))
                {
                    result += (after - 96);
                }
            }
            Console.WriteLine($"{result:f2}");
        }

        static decimal Num(char[] text)
        {
            string a = "";
            foreach (var item in text)
            {
                a += item;
            }

            decimal num = decimal.Parse(a);
            return num;
        }
    }
}
