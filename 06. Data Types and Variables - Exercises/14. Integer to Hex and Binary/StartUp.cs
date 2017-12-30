namespace _14.Integer_to_Hex_and_Binary
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var decimalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(decimalNumber, 16).ToUpper());
            Console.WriteLine(Convert.ToString(decimalNumber, 2));
        }
    }
}