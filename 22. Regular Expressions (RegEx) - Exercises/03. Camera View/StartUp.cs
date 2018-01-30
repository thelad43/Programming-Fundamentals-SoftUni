namespace _03.Camera_View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var skip = inputParams[0];
            var take = inputParams[1];
            var text = Console.ReadLine();
            var regex = @"(?<=\|<.{" + skip + "})([^|]{0," + take + "})";
            var words = Regex.Matches(text, regex);
            var result = new List<string>();

            foreach (Match word in words)
            {
                result.Add(word.Groups[1].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}