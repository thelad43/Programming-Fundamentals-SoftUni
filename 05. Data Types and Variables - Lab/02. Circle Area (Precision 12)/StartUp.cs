namespace _02.Circle_Area__Precision_12_
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(Math.PI * radius * radius):F12}");
        }
    }
}