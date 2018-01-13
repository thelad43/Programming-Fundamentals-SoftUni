namespace _01.Max_Sequence_of_Equal_Elements
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

            var bestSequance = GetLongestSequence(numbers);
            Console.WriteLine(string.Join(" ", bestSequance));
        }

        private static List<int> GetLongestSequence(List<int> numbers)
        {
            var maxLength = 1;
            var currentLength = 1;
            var maxIndex = 0;
            var currentIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentIndex = i;
                    currentLength = 1;
                }

                if (maxLength < currentLength)
                {
                    maxLength = currentLength;
                    maxIndex = currentIndex;
                }
            }

            var longestSequance = new List<int>();

            for (int i = 0; i < maxLength; i++)
            {
                longestSequance.Add(numbers[maxIndex + i]);
            }

            return longestSequance;
        }
    }
}