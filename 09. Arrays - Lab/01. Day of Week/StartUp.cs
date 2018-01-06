namespace _01.Day_of_Week
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var day = int.Parse(Console.ReadLine());
            var days = new string[]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            try
            {
                Console.WriteLine(days[day - 1]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}