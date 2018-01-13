namespace _02.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var countOfOccurrences = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!countOfOccurrences.ContainsKey(words[i]))
                {
                    countOfOccurrences[words[i]] = 1;
                    continue;
                }

                countOfOccurrences[words[i]]++;
            }

            var result = new StringBuilder();

            foreach (var kvp in countOfOccurrences)
            {
                if (kvp.Value % 2 == 1)
                {
                    result.Append($"{kvp.Key}, ");
                }
            }

            Console.WriteLine(result.ToString().Trim(' ', ','));
        }
    }
}