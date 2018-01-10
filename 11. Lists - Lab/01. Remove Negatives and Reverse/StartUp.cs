namespace _01.Remove_Negatives_and_Reverse
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
                .Where(n => n > 0)
                .Reverse()
                .ToList();

            var result = numbers.Count != 0 ? string.Join(" ", numbers) : "empty";
            Console.WriteLine(result);
        }
    }
}