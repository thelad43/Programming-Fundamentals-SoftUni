namespace _15.Substring
{
    using System;

    public class StartUp
    {
        private const char Search = 'p';

        public static void Main()
        {
            var text = Console.ReadLine();
            var jump = int.Parse(Console.ReadLine());
            var hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;
                    var endIndex = jump;

                    if (endIndex > text.Length)
                    {
                        endIndex = text.Length;
                    }

                    string matchedString;
                    try
                    {
                        matchedString = text.Substring(i, endIndex + 1);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        matchedString = text.Substring(i, endIndex);
                    }

                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}