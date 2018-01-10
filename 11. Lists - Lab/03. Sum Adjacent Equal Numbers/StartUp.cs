namespace _03.Sum_Adjacent_Equal_Numbers
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
                .Select(double.Parse)
                .ToList();

            SumAdjacentEqualNumbers(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SumAdjacentEqualNumbers(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    var sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    numbers[i] = sum;
                    SumAdjacentEqualNumbers(numbers);
                }
            }
        }
    }
}