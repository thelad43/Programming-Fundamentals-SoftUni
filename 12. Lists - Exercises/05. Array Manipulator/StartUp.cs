namespace _05.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var commandTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (commandTokens[0] != "print")
            {
                switch (commandTokens[0])
                {
                    case "add":
                        numbers.Insert(int.Parse(commandTokens[1]),
                            int.Parse(commandTokens[2]));

                        break;

                    case "addMany":
                        var position = int.Parse(commandTokens[1]);

                        for (int i = 2; i < commandTokens.Length; i++)
                        {
                            numbers.Insert(position, int.Parse(commandTokens[i]));
                            position++;
                        }

                        break;

                    case "contains":
                        var index = numbers.IndexOf(int.Parse(commandTokens[1]));
                        Console.WriteLine(index);
                        break;

                    case "remove":
                        numbers.RemoveAt(int.Parse(commandTokens[1]));
                        break;

                    case "shift":
                        var rotations = int.Parse(commandTokens[1]) % numbers.Count;
                        var moved = new List<int>();

                        for (int i = 0; i < rotations; i++)
                        {
                            moved.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }

                        numbers.AddRange(moved);
                        break;

                    case "sumPairs":
                        for (int i = 0; i < numbers.Count - numbers.Count % 2; i += 2)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers[i + 1] = -1;
                        }

                        numbers.RemoveAll(x => x == -1);
                        break;

                    default:
                        throw new ArgumentException();
                }

                commandTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}