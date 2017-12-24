namespace _05.Foreign_Languages
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            switch (Console.ReadLine())
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}