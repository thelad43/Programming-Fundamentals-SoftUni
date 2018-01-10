namespace _04.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var words = text
                .Split(",;:.!()\"'\\/[] "
                .ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var word in words)
            {
                if (IsLowerCase(word))
                {
                    lowerCaseWords.Add(word);
                }
                else if (IsUpperCase(word))
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            PrintLists(upperCaseWords, lowerCaseWords, mixedCaseWords);
        }

        private static void PrintLists(List<string> upperCaseWords, List<string> lowerCaseWords, List<string> mixedCaseWords)
        {
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }

        private static bool IsLowerCase(string word)
        {
            var isLowerCase = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLower(word[i]))
                {
                    return false;
                }
            }

            return isLowerCase;
        }

        private static bool IsUpperCase(string word)
        {
            var isUpperCase = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsUpper(word[i]))
                {
                    return false;
                }
            }

            return isUpperCase;
        }
    }
}