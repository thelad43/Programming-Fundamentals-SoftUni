namespace _05.Fibonacci_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = GetFibonacciNumber(n);
            Console.WriteLine(result);
        }

        private static int GetFibonacciNumber(int n)
        {
            var first = 1;
            var second = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var third = first + second;
                first = second;
                second = third;
            }

            return second;
        }
    }
}