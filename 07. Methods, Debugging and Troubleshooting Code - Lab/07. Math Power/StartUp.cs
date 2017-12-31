namespace _07.Math_Power
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            var result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}