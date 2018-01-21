namespace _01.Count_Working_Days
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var format = "dd-MM-yyyy";

            var startDate = DateTime.ParseExact(Console.ReadLine(),
                format, CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(),
            format, CultureInfo.InvariantCulture);

            var officialDays = new DateTime[11]
            {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
        };

            var workingDaysCounter = 0;

            for (var d = startDate; d <= endDate; d = d.AddDays(1))
            {
                var dayOfWeek = d.DayOfWeek;
                var currentDate = new DateTime(4, d.Month, d.Day);

                if (!officialDays.Contains(currentDate) && (!dayOfWeek.Equals(DayOfWeek.Saturday) && !dayOfWeek.Equals(DayOfWeek.Sunday)))
                {
                    workingDaysCounter++;
                }
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}