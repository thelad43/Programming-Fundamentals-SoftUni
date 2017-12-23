namespace _05.Character_Stats
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {new string('|', currentHealth + 1)}{new string('.', maxHealth - currentHealth)}|");
            Console.WriteLine($"Energy: {new string('|', currentEnergy + 1)}{new string('.', maxEnergy - currentEnergy)}|");
        }
    }
}