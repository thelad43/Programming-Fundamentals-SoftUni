namespace _14.Magic_Letter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var thirdLetter = Console.ReadLine();

            var result = string.Empty;

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        result = $"{i}{j}{k}";

                        if (!result.Contains(thirdLetter))
                        {
                            Console.Write($"{result} ");
                        }
                    }
                }
            }
        }
    }
}