namespace _05.Word_in_Plural
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.TrimEnd('y');
                word = word.Insert(word.Length, "ies");
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                word = word.Insert(word.Length, "es");
            }
            else
            {
                word = word.Insert(word.Length, "s");
            }

            Console.WriteLine(word);
        }
    }
}