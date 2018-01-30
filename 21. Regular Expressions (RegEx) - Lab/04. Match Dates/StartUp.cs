namespace _04.Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var dates = Console.ReadLine();
            var pattern = @"\b(?<day>\d{2})([.\/-])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})\b";
            var regex = new Regex(pattern);
            var matches = regex.Matches(dates);

            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}