namespace _01.Most_Frequent_Number
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("../../input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var mostFrequentElement = numbers.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First();

            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            File.WriteAllText("../../output.txt", mostFrequentElement.ToString());
        }
    }
}