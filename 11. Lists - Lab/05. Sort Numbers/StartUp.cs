namespace _05.Sort_Numbers
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
                .Select(double.Parse)
                .OrderBy(n => n)
                .ToList();

            var result = new List<string>(numbers.Count);
            int i;

            for (i = 0; i < numbers.Count - 1; i++)
            {
                result.Add($"{numbers[i]} <= ");
            }

            result.Add(string.Empty + numbers[i]);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}