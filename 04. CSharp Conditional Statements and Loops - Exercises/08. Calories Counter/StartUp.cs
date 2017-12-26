namespace _08.Calories_Counter
{
    using System;

    public class StartUp
    {
        private const int caloriesInCheese = 500;
        private const int caloriesInTomatoSauce = 150;
        private const int caloriesInSalami = 600;
        private const int caloriesInPepper = 50;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string ingredient;
            var calories = 0;

            for (int i = 0; i < n; i++)
            {
                ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        calories += caloriesInCheese;
                        break;

                    case "tomato sauce":
                        calories += caloriesInTomatoSauce;
                        break;

                    case "salami":
                        calories += caloriesInSalami;
                        break;

                    case "pepper":
                        calories += caloriesInPepper;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}