namespace _09.Count_the_Integers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var countOfInts = 0;

            while (int.TryParse(input, out var n))
            {
                countOfInts++;
                input = Console.ReadLine();
            }

            Console.WriteLine(countOfInts);
        }
    }
}