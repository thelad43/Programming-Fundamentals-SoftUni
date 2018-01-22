using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.Word_Count
{
    public class StartUp
    {
        public static void Main()
        {
            var words = File.ReadAllText("../../words.txt")
                 .ToLower()
                 .Split(' ');

            var text = File.ReadAllText("../../text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            if (!File.Exists("../../Output.txt"))
            {
                var file = File.Create("../../Output.txt");
                file.Close();
            }

            var givenWordsCount = new List<string>();
            var containedWords = CountWords(words, text);

            foreach (var kvp in containedWords)
            {
                givenWordsCount.Add($"{kvp.Key} -> {kvp.Value}");
            }

            File.WriteAllLines("../../Output.txt", givenWordsCount);
        }

        private static Dictionary<string, int> CountWords(string[] words, string[] text)
        {
            var containedWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                containedWords[word] = 0;
            }

            foreach (var word in text)
            {
                if (containedWords.ContainsKey(word))
                {
                    containedWords[word]++;
                }
            }

            return containedWords
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}