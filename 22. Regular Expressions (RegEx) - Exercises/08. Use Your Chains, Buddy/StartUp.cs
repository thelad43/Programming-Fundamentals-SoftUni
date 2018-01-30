namespace _08.Use_Your_Chains__Buddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"<p>(.+?)<\/p>";
            var regex = new Regex(pattern);
            var matchesAsString = string.Empty;

            foreach (Match match in regex.Matches(text))
            {
                matchesAsString += match.Groups[1].Value;
            }

            matchesAsString = Regex.Replace(matchesAsString, @"[^a-z\d]", " ");
            matchesAsString = Regex.Replace(matchesAsString, @"\s+|\n+", " ");

            var result = new StringBuilder(matchesAsString.Length);

            foreach (var ch in matchesAsString)
            {
                if (ch >= 'a' && ch <= 'm')
                {
                    result.Append((char)(ch + 13));
                }
                else if (ch >= 'n' && ch <= 'z')
                {
                    result.Append((char)(ch - 13));
                }
                else
                {
                    result.Append(ch);
                }
            }

            Console.WriteLine(result);
        }
    }
}