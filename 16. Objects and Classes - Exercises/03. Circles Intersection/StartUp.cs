namespace _03.Circles_Intersection
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstCircleTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondCircleTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstCircleCenter = new Point(firstCircleTokens[0], firstCircleTokens[1]);
            var secondCircleCenter = new Point(secondCircleTokens[0], secondCircleTokens[1]);

            var firstCircleRadius = firstCircleTokens[2];
            var secondCircleRadius = secondCircleTokens[2];

            var firstCircle = new Circle(firstCircleCenter, firstCircleRadius);
            var secondCircle = new Circle(secondCircleCenter, secondCircleRadius);

            var isIntersect = string.Empty;
            var circlesIntersect = Intersect(firstCircle, secondCircle);
            isIntersect = circlesIntersect == true ? "Yes" : "No";
            Console.WriteLine(isIntersect);
        }

        private static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            var deltaX = Math.Abs(firstCircle.Center.X - secondCircle.Center.X);
            var deltaY = Math.Abs(firstCircle.Center.Y - secondCircle.Center.Y);

            var distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            var sumRadiuses = firstCircle.Radius + secondCircle.Radius;

            if (sumRadiuses >= distance)
            {
                return true;
            }

            return false;
        }
    }
}