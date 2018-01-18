namespace _06.Rectangle_Position
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            if (IsInside(firstRectangle, secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        private static bool IsInside(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            if (firstRectangle.Top <= secondRectangle.Top && firstRectangle.Right <= secondRectangle.Right && firstRectangle.Bottom <= secondRectangle.Bottom && firstRectangle.Left >= secondRectangle.Left)
            {
                return true;
            }

            return false;
        }

        private static Rectangle ReadRectangle()
        {
            var inputParams = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rectangle = new Rectangle(inputParams[0], inputParams[1], inputParams[2],
                inputParams[3], inputParams[0] + inputParams[2],
                inputParams[1] + inputParams[3]);

            return rectangle;
        }
    }
}