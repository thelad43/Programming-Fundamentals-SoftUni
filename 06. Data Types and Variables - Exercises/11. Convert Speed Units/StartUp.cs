namespace _11.Convert_Speed_Units
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var distanceInMeters = float.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());
            var totalSeconds = (ushort)(hours * 3600 + minutes * 60 + seconds);

            Console.WriteLine("{0:0.#######}", distanceInMeters / totalSeconds);
            Console.WriteLine("{0:0.#######}", (distanceInMeters / 1000F) / (totalSeconds / 3600F));
            Console.WriteLine("{0:0.#######}", (distanceInMeters / 1609F) / (totalSeconds / 3600F));
        }
    }
}