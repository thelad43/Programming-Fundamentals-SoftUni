namespace _03.Back_in_30_Minutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var mins = int.Parse(Console.ReadLine());

            var totalMins = hours * 60 + mins + 30;
            var totalHours = (totalMins / 60);
            var resultMins = totalMins % 60;

            if (totalHours == 24 && resultMins < 10)
            {
                Console.WriteLine($"0:0{resultMins}");
            }
            else if (totalHours == 24 && resultMins > 9)
            {
                Console.WriteLine($"0:{resultMins}");
            }
            else if (resultMins < 10)
            {
                Console.WriteLine($"{totalHours}:0{resultMins}");
            }
            else
            {
                Console.WriteLine($"{totalHours}:{resultMins}");
            }
        }
    }
}