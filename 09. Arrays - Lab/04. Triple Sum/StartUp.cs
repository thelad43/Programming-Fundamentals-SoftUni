namespace _04.Triple_Sum
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

            var notFound = true;
            var sum = 0;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    sum = numbers[a] + numbers[b];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");

                        if (notFound)
                        {
                            notFound = false;
                        }
                    }
                }
            }

            if (notFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}