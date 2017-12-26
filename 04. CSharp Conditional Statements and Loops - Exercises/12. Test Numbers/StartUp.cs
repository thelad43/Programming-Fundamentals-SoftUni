namespace _12.Test_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var maximumSumBoundary = int.Parse(Console.ReadLine());

            var sum = 0;
            var totalCombinations = 0;
            var isMagicNumber = false;

            for (int i = a; i >= 1; i--)
            {
                for (int j = 1; j <= b; j++)
                {
                    if (sum >= maximumSumBoundary)
                    {
                        isMagicNumber = true;
                        break;
                    }
                    else
                    {
                        totalCombinations++;
                        sum += 3 * (i * j);
                    }
                }

                if (sum >= maximumSumBoundary)
                {
                    isMagicNumber = true;
                    break;
                }
            }

            Console.WriteLine($"{totalCombinations} combinations");

            if (isMagicNumber)
            {
                Console.WriteLine($"Sum: {sum} >= {maximumSumBoundary }");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}