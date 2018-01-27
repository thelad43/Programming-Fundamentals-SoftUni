namespace _03.Unicode_Characters
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = ConvertToUnicodeCharacterLiterals(input);
            Console.WriteLine(result);
        }

        private static string ConvertToUnicodeCharacterLiterals(string input)
        {
            var symbols = input.ToCharArray();
            var result = new StringBuilder();

            for (int i = 0; i < symbols.Length; i++)
            {
                var cuurentUnicode = GetEscapeSequence(symbols[i]);
                result.Append(cuurentUnicode);
            }

            return result.ToString().ToLower();
        }

        private static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}