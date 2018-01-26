namespace _02.Count_Substring_Occurrences
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var textForSearching = Console.ReadLine().ToLower();
            var occurrencesCount = CountSubstringOccurrences(text, textForSearching);
            Console.WriteLine(occurrencesCount);
        }

        private static int CountSubstringOccurrences(string text, string textForSearching)
        {
            var occurrencesCount = 0;
            var index = text.IndexOf(textForSearching);

            while (index != -1)
            {
                occurrencesCount++;
                index = text.IndexOf(textForSearching, index + 1);
            }

            return occurrencesCount;
        }
    }
}