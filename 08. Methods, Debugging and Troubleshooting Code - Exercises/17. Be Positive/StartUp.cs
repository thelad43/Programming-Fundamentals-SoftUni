namespace _17.Be_Positive
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var sequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < sequences; i++)
            {
                var numbersToPrint = new List<int>();

                var numbers = Console.ReadLine()
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                for (int j = 0; j < numbers.Length; j++)
                {
                    var currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        numbersToPrint.Add(currentNum);
                    }
                    else
                    {
                        if (j == numbers.Length - 1)
                        {
                            break;
                        }

                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            numbersToPrint.Add(currentNum);
                        }

                        j++;
                    }
                }

                if (numbersToPrint.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", numbersToPrint));
                }
                else
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}