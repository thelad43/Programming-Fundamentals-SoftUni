namespace _01.Convert_from_base_10_to_base_N
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            var baseN = inputParams[0];
            var numberInDecimalToConvert = inputParams[1];
            var result = new Stack<int>();

            while (numberInDecimalToConvert > 0)
            {
                var remainder = numberInDecimalToConvert % baseN;
                result.Push((int)remainder);
                numberInDecimalToConvert /= baseN;
            }

            if (result.Any())
                Console.WriteLine(string.Join("", result));
            else
                Console.WriteLine(0);
        }
    }
}