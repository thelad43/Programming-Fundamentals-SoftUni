namespace _11.Equal_Sums
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

            var leftSum = 0;
            var rightSum = 0;
            var hasMatch = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = CalculateLeftSum(numbers, i);
                rightSum = CalculateRightSum(numbers, i);

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    hasMatch = true;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }

        private static int CalculateRightSum(int[] numbers, int i)
        {
            var numbersInRight = numbers.Skip(i + 1).ToArray();
            return numbersInRight.Sum();
        }

        private static int CalculateLeftSum(int[] numbers, int i)
        {
            var numbersInLeft = numbers.Take(i).ToArray();
            return numbersInLeft.Sum();
        }
    }
}