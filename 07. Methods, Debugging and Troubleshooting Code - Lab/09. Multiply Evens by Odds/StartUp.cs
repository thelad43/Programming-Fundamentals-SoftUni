namespace _09.Multiply_Evens_by_Odds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = Math.Abs(int.Parse(Console.ReadLine()));
            var result = MultipliesEvensToOdds(number);
            Console.WriteLine(result);
        }

        private static int GetTheSumOfEvenDigits(int number)
        {
            var evenSum = 0;

            while (number > 0)
            {
                var lastDigit = number % 10;
                number = number / 10;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
            }

            return evenSum;
        }

        private static int GetTheSumOfOddDigits(int number)
        {
            var oddSum = 0;

            while (number > 0)
            {
                var lastDigit = number % 10;
                number = number / 10;

                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
            }

            return oddSum;
        }

        private static int MultipliesEvensToOdds(int number)
        {
            var evenSum = GetTheSumOfEvenDigits(number);
            var oddSum = GetTheSumOfOddDigits(number);

            return evenSum * oddSum;
        }
    }
}