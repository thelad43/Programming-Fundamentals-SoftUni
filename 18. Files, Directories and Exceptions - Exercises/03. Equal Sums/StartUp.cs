namespace _03.Equal_Sums
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("../../input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var leftSum = 0;
            var rightSum = 0;
            var hasMatch = false;

            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = CalculateLeftSum(numbers, i);
                rightSum = CalculateRightSum(numbers, i);

                if (leftSum == rightSum)
                {
                    File.WriteAllText("../../output.txt", i.ToString());
                    hasMatch = true;
                }
            }

            if (!hasMatch)
            {
                File.WriteAllText("../../output.txt", "no");
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