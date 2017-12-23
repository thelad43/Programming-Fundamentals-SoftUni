namespace _02.Rectangle_Area
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var height = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(height * width):F2}");
        }
    }
}