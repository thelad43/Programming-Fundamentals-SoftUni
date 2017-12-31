namespace _03.Printing_Triangle
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        private static void PrintTriangle(int n)
        {
            UpperPartOfTriangle(n);
            MiddlePartOfTriangle(n);
            LowerPartOfTriangle(n);
        }

        private static void UpperPartOfTriangle(int n)
        {
            for (int i = 1; i <= n - 1; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("{0} ", k);
                }

                Console.WriteLine();
            }
        }

        private static void MiddlePartOfTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }

        private static void LowerPartOfTriangle(int n)
        {
            for (int i = 1; i <= n - 1; i++)
            {
                for (int k = 1; k <= n - 1 - i + 1; k++)
                {
                    Console.Write("{0} ", k);
                }

                Console.WriteLine();
            }
        }
    }
}