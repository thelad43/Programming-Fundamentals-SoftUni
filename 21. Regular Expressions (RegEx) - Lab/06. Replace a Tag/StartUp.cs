namespace _06.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            var newPattern = @"[URL href=$1]$2[/URL]";

            while (inputLine != "end")
            {
                Console.WriteLine(Regex.Replace(inputLine, pattern, newPattern));
                inputLine = Console.ReadLine();
            }
        }
    }
}