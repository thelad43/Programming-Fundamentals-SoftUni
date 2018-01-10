namespace _07.Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            var numbersAndOccurrences = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!numbersAndOccurrences.ContainsKey(number))
                {
                    numbersAndOccurrences[number] = 1;
                }
                else
                {
                    numbersAndOccurrences[number]++;
                }
            }

            foreach (var kvp in numbersAndOccurrences.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}