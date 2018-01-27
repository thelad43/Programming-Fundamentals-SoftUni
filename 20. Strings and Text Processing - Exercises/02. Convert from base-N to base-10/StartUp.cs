namespace _02.Convert_from_base_N_to_base_10
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var baseN = int.Parse(inputParams[0]);
            var number = inputParams[1].ToCharArray();
            var result = new BigInteger();

            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                var num = new BigInteger(char.GetNumericValue(number[n]));
                var forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                result += forSum;
            }

            Console.WriteLine(result);
        }
    }
}