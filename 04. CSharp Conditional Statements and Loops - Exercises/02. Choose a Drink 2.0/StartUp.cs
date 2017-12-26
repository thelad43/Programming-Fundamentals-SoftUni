namespace _02.Choose_a_Drink_2._0
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 0.7):F2}.");
                    break;

                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.0):F2}.");
                    break;

                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.7):F2}.");
                    break;

                default:
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.2):F2}.");
                    break;
            }
        }
    }
}