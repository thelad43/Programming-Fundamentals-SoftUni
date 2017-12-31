namespace _06.Calculate_Triangle_Area
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var baseTriangle = double.Parse(Console.ReadLine());
            var heightTriangle = double.Parse(Console.ReadLine());
            var area = GetTriangleArea(baseTriangle, heightTriangle);
            Console.WriteLine(area);
        }

        private static double GetTriangleArea(double baseTriangle, double heightTriangle)
        {
            return baseTriangle * heightTriangle / 2;
        }
    }
}