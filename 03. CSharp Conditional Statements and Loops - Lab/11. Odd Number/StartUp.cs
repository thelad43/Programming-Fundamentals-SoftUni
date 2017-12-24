namespace _11.Odd_Number
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            while (n % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(n)}");
        }
    }
}