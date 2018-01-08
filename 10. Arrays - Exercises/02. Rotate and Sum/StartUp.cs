namespace _02.Rotate_and_Sum
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
                .ToArray();

            var k = int.Parse(Console.ReadLine());
            var rotatedArray = RotateArrayOnTheRight(numbers, k);
            Console.WriteLine(string.Join(" ", rotatedArray));
        }

        private static int[] RotateArrayOnTheRight(int[] numbers, int k)
        {
            var result = new int[numbers.Length];

            for (int i = 1; i <= k; i++)
            {
                for (int n = 0; n < numbers.Length; n++)
                {
                    var index = ((numbers.Length - (i % numbers.Length == 0 ?
                        numbers.Length : i % numbers.Length)) + n) % numbers.Length;

                    result[n] += numbers[index];
                }
            }

            return result;
        }
    }
}