namespace _02.Add_Two_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
        }
    }
}