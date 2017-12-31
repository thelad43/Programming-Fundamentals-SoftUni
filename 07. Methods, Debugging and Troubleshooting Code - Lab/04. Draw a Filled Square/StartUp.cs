namespace _04.Draw_a_Filled_Square
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintFilledSquare(n);
        }

        private static void PrintFilledSquare(int n)
        {
            PrintFirstOrLastLine(n);

            PrintMiddlePart(n);

            PrintFirstOrLastLine(n);
        }

        private static void PrintMiddlePart(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");

                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine("-");
            }
        }

        private static void PrintFirstOrLastLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}