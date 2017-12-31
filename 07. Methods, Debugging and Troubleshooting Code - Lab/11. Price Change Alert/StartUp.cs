namespace _11.Price_Change_Alert
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var significanceThreshold = double.Parse(Console.ReadLine());
            var previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                var currentPrice = double.Parse(Console.ReadLine());
                var difference = CalculateDifference(previousPrice, currentPrice);
                var isSignificantDifference = IsDifferenceSignificant(difference, significanceThreshold);

                var message = GetAlertMessage(currentPrice, previousPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                previousPrice = currentPrice;
            }
        }

        private static string GetAlertMessage(double currentPrice, double previousPrice, double difference, bool isSignificantDifference)
        {
            var message = string.Empty;

            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }

            return message;
        }

        private static bool IsDifferenceSignificant(double difference, double threshold)
        {
            if (Math.Abs(threshold) <= Math.Abs(difference))
            {
                return true;
            }

            return false;
        }

        private static double CalculateDifference(double previousPrice, double currentPrice)
        {
            return (currentPrice - previousPrice) / previousPrice;
        }
    }
}