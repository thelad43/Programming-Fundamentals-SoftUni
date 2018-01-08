namespace _05.Compare_Char_Arrays
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstCharArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            var secondCharArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            if (firstCharArray.Length == secondCharArray.Length)
            {
                if (firstCharArray[0] < secondCharArray[0])
                {
                    Console.WriteLine(firstCharArray);
                    Console.WriteLine(secondCharArray);
                }
                else
                {
                    Console.WriteLine(secondCharArray);
                    Console.WriteLine(firstCharArray);
                }
            }
            else if (firstCharArray.Length > secondCharArray.Length)
            {
                Console.WriteLine(secondCharArray);
                Console.WriteLine(firstCharArray);
            }
            else
            {
                Console.WriteLine(firstCharArray);
                Console.WriteLine(secondCharArray);
            }
        }
    }
}