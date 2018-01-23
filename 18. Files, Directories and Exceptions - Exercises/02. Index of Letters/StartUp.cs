namespace _02.Index_of_Letters
{
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var word = File.ReadAllText("../../input.txt").ToLower();

            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            var result = new string[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                result[i] = $"{word[i]} -> {word[i] - 'a'}";
            }

            File.WriteAllLines("../../output.txt", result);
        }
    }
}