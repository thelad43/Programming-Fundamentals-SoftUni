namespace _10.Cube_Properties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine().ToLower();
            var result = 0D;

            switch (parameter)
            {
                case "face":
                    result = GetFaceDiagonals(side);
                    break;

                case "space":
                    result = GetSpaceDiagonals(side);
                    break;

                case "volume":
                    result = GetVolume(side);
                    break;

                case "area":
                    result = GetSurfaceArea(side);
                    break;

                default:
                    throw new ArgumentException();
            }

            Console.WriteLine($"{result:F2}");
        }

        private static double GetSurfaceArea(double side)
        {
            return 6 * (side * side);
        }

        private static double GetVolume(double side)
        {
            return side * side * side;
        }

        private static double GetSpaceDiagonals(double side)
        {
            return Math.Sqrt(3 * (side * side));
        }

        private static double GetFaceDiagonals(double side)
        {
            return Math.Sqrt(2 * (side * side));
        }
    }
}