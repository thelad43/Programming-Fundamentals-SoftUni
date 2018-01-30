namespace _06.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var splitter = @"\W+";

            var usernames = Regex.Replace(line, splitter, " ")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = @"^[a-zA-Z][a-zA-Z0-9_]{2,24}$";
            var regex = new Regex(pattern);
            var validUsernames = new List<string>();

            foreach (var username in usernames)
            {
                if (regex.IsMatch(username))
                {
                    validUsernames.Add(username);
                }
            }

            var biggestSum = 0;
            var firstUsername = String.Empty;
            var secondUsername = String.Empty;

            for (int i = 1; i < validUsernames.Count; i++)
            {
                var currentSum = validUsernames[i - 1].Length + validUsernames[i].Length;

                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    firstUsername = validUsernames[i - 1];
                    secondUsername = validUsernames[i];
                }
            }

            Console.WriteLine($"{firstUsername}{Environment.NewLine}{secondUsername}");
        }
    }
}