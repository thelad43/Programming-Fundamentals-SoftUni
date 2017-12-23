namespace _03.Miles_to_Kilometers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(miles * 1.60934):F2}");
        }
    }
}