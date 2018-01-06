namespace _06.Reverse_Array_of_Strings
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var arrayOfStrings = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(arrayOfStrings);
            Console.WriteLine(string.Join(" ", arrayOfStrings));
        }
    }
}