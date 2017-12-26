namespace _04.Hotel
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            decimal studioPrice = 0;
            decimal doublePrice = 0;
            decimal suitePrice = 0;

            switch (month)
            {
                case "May":
                case "October":

                    studioPrice = 50;
                    if (nightsCount > 7)
                    {
                        studioPrice *= 0.95M;
                    }
                    doublePrice = 65;

                    suitePrice = 75;
                    break;

                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;

                    if (nightsCount > 14)
                    {
                        doublePrice *= 0.90M;
                    }
                    suitePrice = 82;
                    break;

                case "July":
                case "August":
                case "December":
                    studioPrice = 68;

                    doublePrice = 77;

                    suitePrice = 89;

                    if (nightsCount > 14)
                    {
                        suitePrice *= 0.85M;
                    }
                    break;
            }

            var totalStudioPrice = studioPrice * nightsCount;
            var totalDoublePrice = doublePrice * nightsCount;
            var totalSuitePrice = suitePrice * nightsCount;

            if ((month == "September" && nightsCount > 7) ||
                    (month == "October" && nightsCount > 7))
            {
                totalStudioPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:F2} lv.");
        }
    }
}