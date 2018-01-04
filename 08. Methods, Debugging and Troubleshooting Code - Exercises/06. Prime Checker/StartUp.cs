﻿namespace _06.Prime_Checker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var isPrime = IsPrime(n);
            Console.WriteLine(isPrime);
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