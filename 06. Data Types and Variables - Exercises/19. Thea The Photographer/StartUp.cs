namespace _19.Thea_The_Photographer
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var pics = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var percentage = filterFactor / 100.0;
            var usefulPictures = (int)Math.Ceiling(pics * percentage);

            var totalPictures = pics * (long)filterTime;
            var uploadedPictures = usefulPictures * (long)uploadTime;

            Console.WriteLine(TimeSpan.FromSeconds(totalPictures + uploadedPictures)
                    .ToString(new string('d', 1) + @"\:hh\:mm\:ss", CultureInfo.InvariantCulture));
        }
    }
}