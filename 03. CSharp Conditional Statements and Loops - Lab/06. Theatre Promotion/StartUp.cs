namespace _06.Theatre_Promotion
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var result = 0M;

            if (age < 0)
            {
                Console.WriteLine("Error!");
                return;
            }

            switch (typeOfDay)
            {
                case "Weekday":
                    if (age <= 18)
                    {
                        result = 12;
                    }
                    else if (age <= 64)
                    {
                        result = 18;
                    }
                    else if (age <= 122)
                    {
                        result = 12;
                    }
                    break;

                case "Weekend":
                    if (age <= 18)
                    {
                        result = 15;
                    }
                    else if (age <= 64)
                    {
                        result = 20;
                    }
                    else if (age <= 122)
                    {
                        result = 15;
                    }
                    break;

                case "Holiday":
                    if (age <= 18)
                    {
                        result = 5;
                    }
                    else if (age <= 64)
                    {
                        result = 12;
                    }
                    else if (age <= 122)
                    {
                        result = 10;
                    }
                    break;

                default:
                    Console.WriteLine("Error!");
                    return;
            }

            if (result > 0)
            {
                Console.WriteLine($"{result}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}