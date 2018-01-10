namespace _02.Append_Lists
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var tokens = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            foreach (var list in tokens)
            {
                var numbers = list
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                Console.Write(string.Join(" ", numbers) + " ");
            }
        }
    }
}