namespace _11.Geometry_Calculator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var figureType = Console.ReadLine().ToLower();
            double area = GetArea(figureType);
            Console.WriteLine($"{area:F2}");
        }

        private static double GetArea(string figureType)
        {
            double area;
            switch (figureType)
            {
                case "triangle":
                    var triangleSide = double.Parse(Console.ReadLine());
                    var triangleHeight = double.Parse(Console.ReadLine());
                    area = triangleSide * triangleHeight / 2;
                    break;

                case "square":
                    var squareSide = double.Parse(Console.ReadLine());
                    area = squareSide * squareSide;
                    break;

                case "rectangle":
                    var rectangleHeight = double.Parse(Console.ReadLine());
                    var rectangleWidth = double.Parse(Console.ReadLine());
                    area = rectangleHeight * rectangleWidth;
                    break;

                case "circle":
                    var circleRadius = double.Parse(Console.ReadLine());
                    area = Math.PI * circleRadius * circleRadius;
                    break;

                default:
                    throw new ArgumentException();
            }

            return area;
        }
    }
}