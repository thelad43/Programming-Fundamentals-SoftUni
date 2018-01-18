namespace _01.Day_of_Week
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var format = "d-M-yyyy";
            var date = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}