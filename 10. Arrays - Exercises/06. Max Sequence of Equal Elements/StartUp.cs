namespace _06.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var start = 0;
            var bestStart = 0;
            var length = 0;
            var bestLength = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[start] == numbers[i])
                {
                    length++;

                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start++;
                    i = start;
                    length = 0;
                }
            }

            for (int i = 0; i <= bestLength; i++)
            {
                Console.Write($"{numbers[bestStart + i]} ");
            }
        }
    }
}