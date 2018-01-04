namespace _12.Master_Number
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && IsSumOfDigitsDivisibleBySeven(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int n)
        {
            if (n == 0)
                return true;

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    return true;
                }

                n /= 10;
            }

            return false;
        }

        private static bool IsSumOfDigitsDivisibleBySeven(int n)
        {
            var digits = Array.ConvertAll(n.ToString().ToArray(), x => x - 48);
            var sum = 0;

            foreach (var digit in digits)
            {
                sum += digit;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsPalindrome(int n)
        {
            var remainder = 0;
            var oldValue = n;
            var reversed = 0;

            while (n > 0)
            {
                remainder = n % 10;
                reversed = reversed * 10 + remainder;
                n /= 10;
            }

            if (oldValue == reversed)
            {
                return true;
            }

            return false;
        }
    }
}