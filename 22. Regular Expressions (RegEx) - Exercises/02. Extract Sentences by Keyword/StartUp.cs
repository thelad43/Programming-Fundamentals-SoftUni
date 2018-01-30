namespace _02.Extract_Sentences_by_Keyword
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var pattern = $"[^.!?;]*(({word}\\W)|(\\W{word}\\W))[^.!?;]*";
            var text = Console.ReadLine();
            var regex = new Regex(pattern);
            var matches = Regex.Matches(text, pattern);
            var count = 0;

            foreach (Match match in matches)
            {
                if (count == 0)
                {
                    Console.WriteLine(match);
                }
                else
                {
                    var sentence = Convert.ToString(match);
                    Console.WriteLine(sentence.Substring(1));
                }

                count++;
            }
        }
    }
}