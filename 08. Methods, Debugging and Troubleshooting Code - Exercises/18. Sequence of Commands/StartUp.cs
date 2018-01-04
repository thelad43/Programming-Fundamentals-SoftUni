namespace _18.Sequence_of_Commands
{
    using System;
    using System.Linq;

    public class StartUp
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            var sizeOfArray = int.Parse(Console.ReadLine());

            var array = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();

            var command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                var args = command.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                PerformAction(args, array);
                Console.WriteLine(string.Join(" ", array));
                command = Console.ReadLine();
            }
        }

        private static void PerformAction(string[] args, long[] array)
        {
            var action = args[0];

            if (args.Length > 1)
            {
                var index = int.Parse(args[1]) - 1;
                var value = int.Parse(args[2]);

                switch (action)
                {
                    case "add":
                        array[index] += value;
                        break;

                    case "subtract":
                        array[index] -= value;
                        break;

                    case "multiply":
                        array[index] *= value;
                        break;
                }
            }
            else if (args[0] == "lshift")
            {
                ArrayShiftLeft(array);
            }
            else if (args[0] == "rshift")
            {
                ArrayShiftRight(array);
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            var lastNumber = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastNumber;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            var firstNumber = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstNumber;
        }
    }
}