namespace _08.Sum_of_Odd_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var x = 1;

            for (int i = 1; x <= n; i += 2)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                    x++;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}