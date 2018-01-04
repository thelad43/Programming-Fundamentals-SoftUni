namespace _09.Longer_Line
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var distancePoint1 = CalculateDistance(x1, y1);
            var distancePoint2 = CalculateDistance(x2, y2);
            var distancePoint3 = CalculateDistance(x3, y3);
            var distancePoint4 = CalculateDistance(x4, y4);

            PrintDistance(x1, y1, x2, y2, x3, y3, x4, y4, distancePoint1, distancePoint2, distancePoint3, distancePoint4);
        }

        private static void PrintDistance(double x1, double y1, double x2, double y2, double x3, double y3, double x4,
            double y4, double distancePoint1, double distancePoint2, double distancePoint3, double distancePoint4)
        {
            var firstLengthPoint = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            var secondLengthPoint = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));

            if (firstLengthPoint >= secondLengthPoint)
            {
                if (distancePoint1 <= distancePoint2)
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                if (distancePoint3 <= distancePoint4)
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                else
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }

        private static double CalculateDistance(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}