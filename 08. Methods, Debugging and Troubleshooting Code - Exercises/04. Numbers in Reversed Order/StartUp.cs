namespace _04.Numbers_in_Reversed_Order
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var result = ReverseNum(num);
            Console.WriteLine(result);
        }

        private static string ReverseNum(double num)
        {
            var digits = num.ToString().ToCharArray();
            Array.Reverse(digits);
            var result = string.Join("", digits);
            return result;
        }
    }
}