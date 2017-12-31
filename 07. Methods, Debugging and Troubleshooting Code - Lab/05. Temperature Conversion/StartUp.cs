namespace _05.Temperature_Conversion
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var fahrenheitTemp = double.Parse(Console.ReadLine());
            var celsius = FahrenheitToCelsius(fahrenheitTemp);
            Console.WriteLine($"{celsius:F2}");
        }

        private static double FahrenheitToCelsius(double fahrenheitTemp)
        {
            return (fahrenheitTemp - 32) * 5 / 9;
        }
    }
}