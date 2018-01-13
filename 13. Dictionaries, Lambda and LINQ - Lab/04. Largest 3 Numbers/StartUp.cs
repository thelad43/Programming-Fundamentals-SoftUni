namespace _04.Largest_3_Numbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .OrderByDescending(n => n)
                .Take(3)));
        }
    }
}