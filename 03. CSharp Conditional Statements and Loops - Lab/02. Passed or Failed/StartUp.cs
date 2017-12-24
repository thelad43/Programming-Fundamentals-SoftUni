namespace _02.Passed_or_Failed
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade < 3)
            {
                Console.WriteLine("Failed!");
            }
            else
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}