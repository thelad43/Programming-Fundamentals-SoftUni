namespace _13.Vowel_or_Digit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            bool parsed;
            parsed = char.TryParse(Console.ReadLine().ToLower(), out var input);

            if (!parsed)
            {
                Console.WriteLine("other");
                return;
            }

            if (char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else if (IsVowel(input))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }

        private static bool IsVowel(char input)
        {
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                return true;
            }

            return false;
        }
    }
}