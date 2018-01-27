namespace _04.Character_Multiplier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var sum = GetSumOfStrings(inputParams[0], inputParams[1]);
            Console.WriteLine(sum);
        }

        private static long GetSumOfStrings(string firstString, string secondString)
        {
            var sum = 0L;

            if (firstString.CompareTo(secondString) != 0)
            {
                sum = GetSumOfStringsWithDifferentLengths(firstString, secondString);
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }
            }

            return sum;
        }

        private static long GetSumOfStringsWithDifferentLengths(string firstString, string secondString)
        {
            var sum = 0L;

            if (firstString.Length > secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    try
                    {
                        var currentChar = secondString[i];
                        sum += firstString[i] * secondString[i];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        for (int k = i; k < firstString.Length; k++)
                        {
                            sum += firstString[k];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    try
                    {
                        var currentChar = firstString[i];
                        sum += firstString[i] * secondString[i];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        for (int k = i; k < secondString.Length; k++)
                        {
                            sum += secondString[k];
                            i++;
                        }
                    }
                }
            }

            return sum;
        }
    }
}