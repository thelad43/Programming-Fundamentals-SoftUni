namespace _04.Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var namesAndEmails = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                var email = Console.ReadLine();

                if (!(email.EndsWith("us") || email.EndsWith("uk")))
                {
                    namesAndEmails[name] = email;
                }
            }

            foreach (var kvp in namesAndEmails)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}