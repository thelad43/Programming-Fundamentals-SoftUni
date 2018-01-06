namespace _02.Reverse_Array_of_Integers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}