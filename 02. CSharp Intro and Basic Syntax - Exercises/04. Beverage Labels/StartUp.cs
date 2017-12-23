namespace _04.Beverage_Labels
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContentPer100ml = double.Parse(Console.ReadLine());
            var sugarContentPer100ml = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(volume / 100 * energyContentPer100ml)}kcal, {volume / 100 * sugarContentPer100ml}g sugars");
        }
    }
}