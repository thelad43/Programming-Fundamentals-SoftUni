namespace _14.Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var factorial = CalculateFactorial(n);
            var trailingZeroes = CalculateTrailingZeroes(factorial);
            Console.WriteLine(trailingZeroes);
        }

        private static int CalculateTrailingZeroes(BigInteger factorial)
        {
            var factorialReversed = factorial.ToString().ToCharArray();
            Array.Reverse(factorialReversed);
            var count = 0;

            foreach (var num in factorialReversed)
            {
                if (num == '0')
                {
                    count++;
                }
                else
                {
                    return count;
                }
            }

            return count;
        }

        private static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}