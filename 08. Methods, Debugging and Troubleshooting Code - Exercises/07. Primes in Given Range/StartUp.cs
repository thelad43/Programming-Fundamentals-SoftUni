namespace _07.Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var startNum = long.Parse(Console.ReadLine());
            var endNum = long.Parse(Console.ReadLine());
            var primeNumbers = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primeNumbers));
        }

        private static List<long> FindPrimesInRange(long startNum, long endNum)
        {
            var primeNumbers = new List<long>();

            for (long i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers;
        }

        private static bool IsPrime(long number)
        {
            if (number == 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}