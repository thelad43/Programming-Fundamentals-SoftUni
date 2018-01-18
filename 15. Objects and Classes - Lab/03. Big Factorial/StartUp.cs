namespace _03.Big_Factorial
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var factorial = CalculateFactorial(n);
            Console.WriteLine(factorial);
        }

        private static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}