namespace _05.Special_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var sum = 0;
                var num = i;

                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                var isSpecial = sum == 5 || sum == 7 || sum == 11 ? true : false;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}