namespace _12.Number_Checker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (double.TryParse(input, out var num))
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}