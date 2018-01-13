namespace _02.Change_List
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
                  .ToList();

            var cmd = Console.ReadLine();

            while (cmd != "Odd" && cmd != "Even")
            {
                var tokens = cmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];

                if (command == "Delete")
                {
                    var element = int.Parse(tokens[1]);
                    numbers.RemoveAll(n => n == element);
                }
                else
                {
                    var element = int.Parse(tokens[1]);
                    var position = int.Parse(tokens[2]);
                    numbers.Insert(position, element);
                }

                cmd = Console.ReadLine();
            }

            if (cmd == "Even")
            {
                numbers
                    .Where(n => n % 2 == 0)
                    .ToList()
                    .ForEach(n => Console.Write($"{n} "));
            }
            else
            {
                numbers
                   .Where(n => n % 2 == 1)
                   .ToList()
                   .ForEach(n => Console.Write($"{n} "));
            }
        }
    }
}