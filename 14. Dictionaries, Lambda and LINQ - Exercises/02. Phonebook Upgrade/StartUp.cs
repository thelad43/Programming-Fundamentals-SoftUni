namespace _02.Phonebook_Upgrade
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var sortedPhoneBook = new SortedDictionary<string, string>();

            while (inputLine != "END")
            {
                var inputParams = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = inputParams[0];

                if (command == "A")
                {
                    var name = inputParams[1];
                    var phone = inputParams[2];
                    sortedPhoneBook[name] = phone;
                }
                else if (command == "S")
                {
                    var name = inputParams[1];

                    if (sortedPhoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {sortedPhoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var kvp in sortedPhoneBook)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
                else
                {
                    throw new ArgumentException();
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}