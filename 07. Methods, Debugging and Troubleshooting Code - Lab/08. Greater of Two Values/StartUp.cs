namespace _08.Greater_of_Two_Values
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    var firstNum = int.Parse(Console.ReadLine());
                    var secondNum = int.Parse(Console.ReadLine());
                    var biggerNum = GetMax(firstNum, secondNum);
                    Console.WriteLine(biggerNum);
                    break;

                case "char":
                    var firstChar = char.Parse(Console.ReadLine());
                    var secondChar = char.Parse(Console.ReadLine());
                    var biggerChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(biggerChar);
                    break;

                case "string":
                    var firstString = Console.ReadLine();
                    var secondString = Console.ReadLine();
                    var biggerString = GetMax(firstString, secondString);
                    Console.WriteLine(biggerString);
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
                return firstNumber;

            return secondNumber;
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
                return firstChar;

            return secondChar;
        }

        private static string GetMax(string firstStr, string secondStr)
        {
            if (firstStr.CompareTo(secondStr) > 0)
                return firstStr;

            return secondStr;
        }
    }
}