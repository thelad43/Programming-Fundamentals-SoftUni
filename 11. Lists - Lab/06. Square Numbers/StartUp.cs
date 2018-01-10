namespace _06.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            var squareNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    squareNumbers.Add(number);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}