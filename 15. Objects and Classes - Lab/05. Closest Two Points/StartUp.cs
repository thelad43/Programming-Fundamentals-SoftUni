namespace _05.Closest_Two_Points
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var points = ReadPoints();
            var closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        private static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        private static void PrintDistance(Point[] points)
        {
            var distance = CalculateDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
        }

        private static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    var distance = CalculateDistance(points[p1], points[p2]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            }

            return closestTwoPoints;
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var sideA = secondPoint.X - firstPoint.X;
            var sideB = secondPoint.Y - firstPoint.Y;
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }

        private static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                var pointTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var x = pointTokens[0];
                var y = pointTokens[1];
                points[i] = new Point(x, y);
            }

            return points;
        }
    }
}