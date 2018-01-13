namespace _06.Fold_and_Sum
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

            var k = numbers.Length / 4;
            var rowLeft = numbers.Take(k).Reverse();
            var rowRight = numbers.Reverse().Take(k);
            var firstRow = rowLeft.Concat(rowRight).ToArray();
            var secondRow = numbers.Skip(k).Take(2 * k).ToArray();
            var sumArr = firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}