namespace _03.Search_for_a_Number
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

            var numbersForOperations = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            var manipulationNumbers = numbers
                .Take(numbersForOperations[0])
                .ToList();

            manipulationNumbers.RemoveRange(0, numbersForOperations[1]);

            if (manipulationNumbers.Contains(numbersForOperations[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}