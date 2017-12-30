namespace _08.Employee_Data
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = Console.ReadLine();
            var gender = Console.ReadLine();
            var id = Console.ReadLine();
            var uniqueEmployeeNumber = Console.ReadLine();

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");
        }
    }
}