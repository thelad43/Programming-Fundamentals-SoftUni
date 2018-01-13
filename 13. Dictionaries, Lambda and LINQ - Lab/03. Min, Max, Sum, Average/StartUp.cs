namespace _03.Min_Max_Sum_Average
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(value: $"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}