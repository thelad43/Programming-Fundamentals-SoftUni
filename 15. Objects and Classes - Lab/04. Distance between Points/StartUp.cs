namespace _04.Distance_between_Points
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstPointTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondPointTokens = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            var firstPoint = new Point(firstPointTokens[0], firstPointTokens[1]);
            var secondPoint = new Point(secondPointTokens[0], secondPointTokens[1]);
            var distance = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:F3}");
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var sideA = secondPoint.X - firstPoint.X;
            var sideB = secondPoint.Y - firstPoint.Y;
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }
}