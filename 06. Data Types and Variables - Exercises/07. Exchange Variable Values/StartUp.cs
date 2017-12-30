namespace _07.Exchange_Variable_Values
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var a = 5;
            var b = 10;

            var oldValue = a;
            a = b;
            b = oldValue;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = 5");
            Console.WriteLine($"b = 10");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}