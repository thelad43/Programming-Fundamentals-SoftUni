namespace _01.Centuries_to_Minutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var centuries = int.Parse(Console.ReadLine());
            var years = centuries * 100;
            var days = (int)(years * 365.2422);
            var hours = days * 24;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {hours * 60} minutes");
        }
    }
}