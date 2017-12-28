namespace _04.Elevator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var courses = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(courses);
        }
    }
}