namespace _07.Bomb_Numbers
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

            var parameters = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var bombNumber = parameters[0];
            var power = parameters[1];
            Detonate(numbers, bombNumber, power);
            Console.WriteLine(numbers.Sum());
        }

        private static void Detonate(List<int> numbers, int bombNumber, int power)
        {
            var index = numbers.IndexOf(bombNumber);

            while (!index.Equals(-1))
            {
                var range = new List<int>();

                if (index < power)
                {
                    range.AddRange(numbers
                        .Take(numbers.Count - (numbers.Count - index) + power + 1));

                    numbers.RemoveRange(0, range.Count);
                }
                else
                {
                    range.AddRange(numbers
                        .Skip(index - power)
                        .Take(2 * power + 1));

                    numbers.RemoveRange(index - power, range.Count);
                }

                index = numbers.IndexOf(bombNumber);
            }
        }
    }
}