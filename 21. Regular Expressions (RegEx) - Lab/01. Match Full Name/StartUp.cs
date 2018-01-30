namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var names = Console.ReadLine();
            var pattern = @"\b([A-Z]{1}[a-z]{1,10}) ([A-Z]{1}[a-z]{1,10})\b";
            var regex = new Regex(pattern);
            var matches = regex.Matches(names);

            foreach (var match in matches)
            {
                Console.Write($"{match} ");
            }
        }
    }
}