namespace _07.Max_Sequence_of_Increasing_Elements
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

            PrintMaxIncSequence(numbers);
        }

        private static void PrintMaxIncSequence(int[] numbers)
        {
            var countCurrentSequance = 0;
            var startCurrentSequance = 0;
            var countMaxSequance = 0;
            var startMaxSequance = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    countCurrentSequance++;
                    startCurrentSequance = i - countCurrentSequance;

                    if (countCurrentSequance > countMaxSequance)
                    {
                        countMaxSequance = countCurrentSequance;
                        startMaxSequance = startCurrentSequance;
                    }
                }
                else
                {
                    countCurrentSequance = 0;
                }
            }

            for (int i = startMaxSequance; i <= startMaxSequance + countMaxSequance; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}