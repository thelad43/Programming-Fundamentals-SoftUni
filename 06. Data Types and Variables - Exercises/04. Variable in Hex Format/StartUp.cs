namespace _04.Variable_in_Hex_Format
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var hexadecimal = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimal, 16));
        }
    }
}