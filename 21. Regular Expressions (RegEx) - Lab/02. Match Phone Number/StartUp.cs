namespace _02.Match_Phone_Number
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var telephoneNumbers = Console.ReadLine();
            var pattern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";
            var regex = new Regex(pattern);

            var matches = regex
                .Matches(telephoneNumbers)
                .Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}