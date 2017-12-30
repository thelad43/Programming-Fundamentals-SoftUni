namespace _17.Print_Part_Of_ASCII_Table
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var from = int.Parse(Console.ReadLine());
            var to = int.Parse(Console.ReadLine());

            for (int i = from; i <= to; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}