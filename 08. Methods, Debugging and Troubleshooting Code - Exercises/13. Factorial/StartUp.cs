namespace _13.Factorial
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = CalculateFactorial(n);
            Console.WriteLine(result);
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