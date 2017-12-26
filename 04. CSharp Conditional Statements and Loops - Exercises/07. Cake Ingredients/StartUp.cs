namespace _07.Cake_Ingredients
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var ingredients = 0;

            while (inputLine != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {inputLine}.");
                ingredients++;
                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}