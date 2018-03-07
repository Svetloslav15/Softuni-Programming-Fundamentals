using System;

namespace _05._BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bmp = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            double bars = Math.Round(beats / 4.0, 1);
            double seconds = beats * 60 / bmp;
            double minutes = (int)seconds / 60;
            seconds -= minutes * 60;
            Console.Write($"{bars} bars - ");
            Console.WriteLine($"{minutes}m {Math.Floor(seconds)}s");
        }
    }
}
