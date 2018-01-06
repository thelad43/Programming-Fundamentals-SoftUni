namespace _09.Extract_Middle_Elements
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

            var middleElements = TakeMiddleElements(numbers, numbers.Length);
            Console.WriteLine("{ " + string.Join(", ", middleElements) + " }");
        }

        private static int[] TakeMiddleElements(int[] numbers, int length)
        {
            if (numbers.Length == 1)
            {
                return numbers;
            }

            if (numbers.Length % 2 == 0)
            {
                var result = new int[2];
                result[0] = numbers[length / 2 - 1];
                result[1] = numbers[length / 2];
                return result;
            }
            else
            {
                var result = new int[3];
                result[0] = numbers[length / 2 - 1];
                result[1] = numbers[length / 2];
                result[2] = numbers[length / 2 + 1];
                return result;
            }
        }
    }
}