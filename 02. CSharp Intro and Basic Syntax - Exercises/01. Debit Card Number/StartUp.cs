namespace _01.Debit_Card_Number
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var forthNumber = int.Parse(Console.ReadLine());

            Console.Write($"{firstNumber.ToString("D4", CultureInfo.InvariantCulture)} ");
            Console.Write($"{secondNumber.ToString("D4", CultureInfo.InvariantCulture)} ");
            Console.Write($"{thirdNumber.ToString("D4", CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"{forthNumber.ToString("D4", CultureInfo.InvariantCulture)}");
        }
    }
}