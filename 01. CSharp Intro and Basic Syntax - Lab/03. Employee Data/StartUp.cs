namespace _03.Employee_Data
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var age = Console.ReadLine();
            var id = int.Parse(Console.ReadLine());
            var salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {id.ToString("D8", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}