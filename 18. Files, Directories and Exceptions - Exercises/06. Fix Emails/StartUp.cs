namespace _06.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var namesAndEmails = new Dictionary<string, string>();
            var data = File.ReadAllLines("../../input.txt");

            for (int i = 1; i < data.Length; i += 2)
            {
                if (data[i].EndsWith("uk") || data[i].EndsWith("us"))
                {
                    continue;
                }

                namesAndEmails[data[i - 1]] = data[i];
            }

            var result = namesAndEmails
                .Select(x => $"{x.Key} -> {x.Value}")
                .ToArray();

            if (!File.Exists("../../output.txt"))
            {
                var file = File.Create("../../output.txt");
                file.Close();
            }

            File.WriteAllLines("../../output.txt", result);
        }
    }
}