namespace _09.Index_of_Letters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var word = Console.ReadLine().ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", word[i], word[i] - 'a');
            }
        }
    }
}