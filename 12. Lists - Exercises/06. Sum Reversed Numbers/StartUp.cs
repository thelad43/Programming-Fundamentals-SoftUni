namespace _06.Sum_Reversed_Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += ReverseNum(numbers[i]);
            }

            Console.WriteLine(sum);
        }

        private static int ReverseNum(int number)
        {
            var reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            return reversed;
        }
    }
}