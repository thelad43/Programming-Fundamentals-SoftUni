namespace _09.Reversed_chars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var thirdLetter = char.Parse(Console.ReadLine());

            Console.Write(thirdLetter);
            Console.Write(secondLetter);
            Console.WriteLine(firstLetter);
        }
    }
}