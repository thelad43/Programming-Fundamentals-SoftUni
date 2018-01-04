namespace _02.Max_Method
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, GetMax(b, c)));
        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}