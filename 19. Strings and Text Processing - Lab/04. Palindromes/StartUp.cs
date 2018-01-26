namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var delimiters = new char[] { ' ', ',', '.', '?', '!' };
            var words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(w => w)));
        }

        private static bool IsPalindrome(string word)
        {
            var isPalindrome = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (!(word[i] == word[word.Length - 1 - i]))
                {
                    return false;
                }
            }

            return isPalindrome;
        }
    }
}