using System;

namespace _19._Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numberOfPictures = ulong.Parse(Console.ReadLine());
            ulong timeForSinglePicture = ulong.Parse(Console.ReadLine());
            ulong percentageOfGoodPictures = ulong.Parse(Console.ReadLine());
            ulong timeForSinglePictureToUpload = ulong.Parse(Console.ReadLine());

            decimal filteredPictures = Math.Ceiling(1.0m * percentageOfGoodPictures * numberOfPictures / 100.0m);
            decimal timeForObrabotation = numberOfPictures * timeForSinglePicture;
            decimal timeToUpload = filteredPictures * timeForSinglePictureToUpload;
            decimal allTime = timeForObrabotation + timeToUpload;

            TimeSpan time = TimeSpan.FromSeconds((double)allTime);

            string magic = @"d\:hh\:mm\:ss";

            Console.WriteLine(time.ToString(magic));
        }
    }
}
