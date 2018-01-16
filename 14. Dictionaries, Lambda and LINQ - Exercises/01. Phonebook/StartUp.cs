namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var phoneBook = new Dictionary<string, string>();

            while (inputLine != "END")
            {
                var inputParams = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = inputParams[0];
                var name = inputParams[1];

                if (command == "A")
                {
                    var phone = inputParams[2];
                    phoneBook[name] = phone;
                }
                else if (command == "S")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
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