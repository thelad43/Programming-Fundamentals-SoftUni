namespace _07.Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"([^&=?\s]*)(?=\=)=(?<=\=)([^&=\s]*)";
            var regex = @"((%20|\+)+)";
            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                var pairs = new Regex(pattern);
                var matches = pairs.Matches(inputLine);
                var result = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    var field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, regex, word => " ").Trim();

                    var value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, regex, word => " ").Trim();

                    if (!result.ContainsKey(field))
                    {
                        var values = new List<string>
                        {
                            value
                        };

                        result.Add(field, values);
                    }
                    else if (result.ContainsKey(field))
                    {
                        result[field].Add(value);
                    }
                }

                foreach (var kvp in result)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }

                Console.WriteLine();
                inputLine = Console.ReadLine();
            }
        }
    }
}