namespace _03.Last_K_Numbers_Sums
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var nums = new long[n];
            nums[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += nums[j];
                    }
                }

                nums[i] = sum;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}