namespace _08.Most_Frequent_Number
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

            var mostFrequentElement = numbers.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
            Console.WriteLine(mostFrequentElement);
        }
    }
}