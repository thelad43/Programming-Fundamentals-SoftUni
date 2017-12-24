namespace _10.Multiplication_Table_2._0
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());
            var isEnteredLoop = false;

            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                isEnteredLoop = true;
            }

            if (!isEnteredLoop)
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
            }
        }
    }
}