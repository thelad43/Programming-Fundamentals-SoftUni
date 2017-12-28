namespace _07.Greeting
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}