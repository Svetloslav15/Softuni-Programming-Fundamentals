using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> filenames = new List<string>();
            string[] judge = Console.ReadLine().Split();
            string filename = Console.ReadLine();
            while (filename != "end")
            {
                bool correct = true;
                foreach (var item in judge)
                {
                    if (filename.Contains(item))
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    filenames.Add(filename);
                }
                filename = Console.ReadLine();
            }
            filenames = filenames.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, filenames));
        }
    }
}
