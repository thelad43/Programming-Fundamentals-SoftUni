namespace _02.Randomize_Words
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var randomGenerator = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var randomNumber = randomGenerator.Next(0, words.Length);
                var oldValue = words[randomNumber];
                words[randomNumber] = words[i];
                words[i] = oldValue;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}