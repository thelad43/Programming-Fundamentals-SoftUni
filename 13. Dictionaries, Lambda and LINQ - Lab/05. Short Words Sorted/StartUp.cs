namespace _05.Short_Words_Sorted
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(".,:;()[]\"'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length < 5)
                .OrderBy(word => word)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}