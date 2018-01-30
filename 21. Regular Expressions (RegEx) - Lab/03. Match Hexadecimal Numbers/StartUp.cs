namespace _03.Match_Hexadecimal_Numbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var hexadecimalNumbers = Console.ReadLine();
            var pattern = @"\b(?:0x)?[\dA-F]+\b";
            var regex = new Regex(pattern);

            var matches = regex
                .Matches(hexadecimalNumbers)
                .Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}